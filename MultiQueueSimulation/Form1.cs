using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public int interArrivalTime;
        public int interArrivalProp;

        public TimeDistribution interArrivalDistribution;
        SimulationSystem system = new SimulationSystem();

        //decimal cummulativeProp = 0;


        private List<string> InterarrivalTime = new List<string>();
        public Form1()
        {
            InitializeComponent();
            //this.system = system;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int GetInterarrivalTime()
        {
            return int.Parse(inter_time.Text);
        }

        public decimal GetInterarrivalProp()
        {
            return Decimal.Parse(inter_prop.Text);
        }


        public int GetInterarrivalTimeForServer()
        {
            return int.Parse(server_time_field.Text);
        }

        public decimal GetInterarrivalPropForServer()
        {
            return Decimal.Parse(server_prob_field.Text);
        }


        public TimeDistribution GetTimeDistribution()
        {
            return interArrivalDistribution;
        }

        private void add_Click(object sender, EventArgs e)
        {
            decimal cummulativeProp = listBox1.Items.Count == 0 ? 0 : system.InterarrivalDistribution[system.InterarrivalDistribution.Count-1].CummProbability;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            interArrivalDistribution.Time = GetInterarrivalTime();
            interArrivalDistribution.Probability = GetInterarrivalProp();
            interArrivalDistribution.MinRange = Convert.ToInt32(cummulativeProp * 100)+1;
            cummulativeProp += GetInterarrivalProp();
            interArrivalDistribution.CummProbability = cummulativeProp;
            interArrivalDistribution.MaxRange = Convert.ToInt32(cummulativeProp * 100);
            system.InterarrivalDistribution.Add(interArrivalDistribution);

            listBox1.Items.Add(GetInterarrivalTime());
            listBox2.Items.Add(GetInterarrivalProp());
            listBox5.Items.Add(cummulativeProp);
            listBox6.Items.Add(interArrivalDistribution.MinRange + "-" + interArrivalDistribution.MaxRange);

            inter_time.Clear();
            inter_prop.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            system.InterarrivalDistribution.Clear();
            MessageBox.Show("Data cleared", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public SimulationSystem GetSystem()
        {
            return system;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();

            int index = system.Servers.FindIndex(item => item.ID == int.Parse(id_field.Text));
            id_label.Text = id_field.Text;
            if (index != -1)
            {
                foreach (TimeDistribution td in system.Servers[index].TimeDistribution)
                {
                    listBox3.Items.Add(td.Time);
                    listBox4.Items.Add(td.Probability);
                    listBox7.Items.Add(td.CummProbability);
                    listBox8.Items.Add(td.MinRange+"-"+td.MaxRange);
                }
            }

            decimal cummulativeProb = 0;
            if (index != -1)
            {
                cummulativeProb = listBox3.Items.Count == 0 ? 0 : system.Servers[index].TimeDistribution[system.Servers[index].TimeDistribution.Count-1].CummProbability;
            }

            TimeDistribution td2 = new TimeDistribution();
            td2.Time = GetInterarrivalTimeForServer();
            td2.Probability = GetInterarrivalPropForServer();
            td2.MinRange = Convert.ToInt32(cummulativeProb * 100)+1;
            cummulativeProb += GetInterarrivalPropForServer();
            td2.CummProbability = cummulativeProb;
            td2.MaxRange = Convert.ToInt32(cummulativeProb * 100);
            if (index != -1)
            {
                system.Servers[index].TimeDistribution.Add(td2);
            } 
            else
            {
                Server theNewServer = new Server();
                theNewServer.ID = int.Parse(id_field.Text);
                theNewServer.TimeDistribution.Add(td2);
                system.Servers.Add(theNewServer);
            }

            

            listBox3.Items.Add(GetInterarrivalTimeForServer());
            listBox4.Items.Add(GetInterarrivalPropForServer());
            listBox7.Items.Add(cummulativeProb);
            listBox8.Items.Add(td2.MinRange+"-"+td2.MaxRange);

            server_time_field.Clear();
            server_prob_field.Clear();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\txt";
            file.Title = "Open a file to read data";
            file.Filter = "Text files only (*.txt) | *.txt";
            file.DefaultExt = "txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                var fileLocation = File.ReadAllLines(file.FileName);
                List<string> lines = new List<string>(fileLocation);
                system.NumberOfServers = int.Parse(lines[1]);
                system.StoppingNumber = int.Parse(lines[4]);
                system.StoppingCriteria = (Enums.StoppingCriteria)int.Parse(lines[7]);
                system.SelectionMethod = (Enums.SelectionMethod)int.Parse(lines[10]);
                decimal cummulativeProb = 0;
                for (int i = 13; i < 17; i++)
                {
                    string[] parts = lines[i].Split(',');
                    TimeDistribution t = CreateTimeDistribution(int.Parse(parts[0].Trim()), decimal.Parse(parts[1].Trim()), ref cummulativeProb);
                    system.InterarrivalDistribution.Add(t);
                }

                Dictionary<int, Dictionary<int, double>> serviceDistributions = new Dictionary<int, Dictionary<int, double>>();
                cummulativeProb = 0;
                int lineIndex = 19;
                for (int serverIndex = 1; serverIndex <= system.NumberOfServers; serverIndex++)
                {
                    Server myNewServer = new Server();
                    myNewServer.ID = serverIndex;
                    while (system.InterarrivalDistribution[system.InterarrivalDistribution.Count-1].CummProbability < 1 && lineIndex < lines.Count)
                    {
                        string[] parts = lines[lineIndex].Split(',');
                        TimeDistribution t = CreateTimeDistribution(int.Parse(parts[0].Trim()), decimal.Parse(parts[1].Trim()), ref cummulativeProb);
                        myNewServer.TimeDistribution.Add(t);
                        system.Servers.Add(myNewServer);
                        lineIndex++;
                    }
                    lineIndex += 5;
                }
            }
            DrawTable();
        }

        private TimeDistribution CreateTimeDistribution(int Time, decimal Prop, ref decimal CummProbability)
        {
            TimeDistribution timeDistribution = new TimeDistribution();
            timeDistribution.Time = Time;
            timeDistribution.Probability = Prop;
            timeDistribution.MinRange = Convert.ToInt32(CummProbability * 100) + 1;
            CummProbability += Prop;
            timeDistribution.CummProbability = CummProbability;
            timeDistribution.MaxRange = Convert.ToInt32(CummProbability * 100);
            return timeDistribution;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            system.NumberOfServers = int.Parse(numOfServersText.Text);
            system.StoppingNumber = int.Parse(stoppinNumText.Text);
            if (stoppingCriteriaText.Text == "1")
                system.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else if (stoppingCriteriaText.Text == "2")
                system.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;

            if (selectionMethodText.Text == "1")
                system.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            else if (selectionMethodText.Text == "2")
                system.SelectionMethod = Enums.SelectionMethod.Random;
            else if (selectionMethodText.Text == "3")
                system.SelectionMethod = Enums.SelectionMethod.LeastUtilization;

            DrawTable();
        }

        private void DrawTable ()
        {
            Form tableView = new Form();
            tableView.Width = 1600;
            tableView.Height = 1000;

            DataGridView data = new DataGridView();
            data.Width = tableView.Width;
            data.Height = tableView.Height;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.White;
            columnHeaderStyle.Font = new Font("Monospace", 8, FontStyle.Bold);
            //data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            data.ColumnHeadersVisible = true;
            string[] columns = new string[] { "Customer No.", "Random Digits for Arrival", "Time between Arrivals", "Clock Time of Arrival", "Random Digits for Service", "Time Service Begins", "Service Time", "Time Service Ends", "Time in Queue", "Server Index" };
            data.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                data.Columns[i].Name = columns[i];
            }
            int accumulationThingy = 0;
            Random randomNum = new Random();
            for (int i = 1; i < system.StoppingNumber; i++)
            {
                int num = randomNum.Next(1, 100);
                int timeBetweenArrival = 0;
                for (int j = 0; j < system.InterarrivalDistribution.Count; j++)
                {
                    if (num >= system.InterarrivalDistribution[j].MinRange && num <= system.InterarrivalDistribution[j].MaxRange)
                    {
                        timeBetweenArrival = system.InterarrivalDistribution[j].Time;
                        break;
                    } 
                    else
                    {
                        timeBetweenArrival = 0;
                    }
                }
                int num2 = randomNum.Next(1, 100);

                if (i==1)
                {
                    num = 0;
                    timeBetweenArrival = 0;
                }
                accumulationThingy += timeBetweenArrival;

                string[] theData = new string[]
                {
                    i.ToString(),
                    num.ToString(),
                    timeBetweenArrival.ToString(),
                    accumulationThingy.ToString(),
                    num2.ToString(),
                    "0",
                    "0",
                    "0",
                    "0",
                    "0"
                };

                data.Rows.Add(theData);
            }

            tableView.Controls.Add(data);
            tableView.ShowDialog();
        }

        private void clear_server_Click(object sender, EventArgs e)
        {
            int index = system.Servers.FindIndex(item => item.ID == int.Parse(id_field.Text));
            if (index != -1)
            {
                system.Servers.RemoveAt(index);
            }
        }
    }
}

