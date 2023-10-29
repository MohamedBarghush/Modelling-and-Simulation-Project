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

        public Form1()
        {
            InitializeComponent();
            //this.system = system;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int GetInterarrivalTime ()
        {
            return Int32.Parse(inter_time.Text);
        }

        public decimal GetInterarrivalProp()
        {
            return Decimal.Parse(inter_prop.Text);
        }

        public TimeDistribution GetTimeDistribution()
        {
            return interArrivalDistribution;
        }

        private void add_Click(object sender, EventArgs e)
        {
            decimal cummulativeProb = 0;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            TimeDistribution t = CreateTimeDistribution(GetInterarrivalTime(), GetInterarrivalProp(), ref cummulativeProb);
            system.InterarrivalDistribution.Add(interArrivalDistribution);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            system.InterarrivalDistribution.Clear();
            MessageBox.Show("Data cleared", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public SimulationSystem GetSystem ()
        {
            return system;
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

                int lineIndex = 19;
                for (int serverIndex = 1; serverIndex <= system.NumberOfServers; serverIndex++)
                {
                    Server myNewServer = new Server();
                    myNewServer.ID = serverIndex;
                    cummulativeProb = 0;
                    while (cummulativeProb < 1 && lineIndex < lines.Count)
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
        }

        private TimeDistribution CreateTimeDistribution (int Time, decimal Prop, ref decimal CummProbability)
        {
            TimeDistribution timeDistribution = new TimeDistribution();
            timeDistribution.Time = Time;
            timeDistribution.Probability = Prop;
            timeDistribution.MinRange = Convert.ToInt32(CummProbability * 100)+1;
            CummProbability += Prop;
            timeDistribution.CummProbability = CummProbability;
            timeDistribution.MaxRange = Convert.ToInt32(CummProbability * 100);
            return timeDistribution;
        }
    }
}
