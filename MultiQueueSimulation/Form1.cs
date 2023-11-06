﻿using System;
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
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;


namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public int interArrivalTime;
        public int interArrivalProp;

        public string actualPath;

        private decimal totalQueueTime = 0;
        private int maxQueue = 0;
        private int customersWhoWaited = 0;
        private List<int> maxQueueList = new List<int>();
        private Dictionary<int, int> queueStuff = new Dictionary<int, int>();
        private int maxDictSize = 0;
        public List<int> endTimes = new List<int>();
        public TimeDistribution interArrivalDistribution;
        public SimulationSystem system = new SimulationSystem();

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

        private void add_Click(object sender, EventArgs e) // Add button in interarrival values
        {
            decimal cummulativeProp = listBox1.Items.Count == 0 ? 0 : system.InterarrivalDistribution[system.InterarrivalDistribution.Count - 1].CummProbability;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            interArrivalDistribution.Time = GetInterarrivalTime();
            interArrivalDistribution.Probability = GetInterarrivalProp();
            interArrivalDistribution.MinRange = Convert.ToInt32(cummulativeProp * 100) + 1;
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

        private void button3_Click(object sender, EventArgs e)  // Add button in servers values
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
                    listBox8.Items.Add(td.MinRange + "-" + td.MaxRange);
                }
            }

            decimal cummulativeProb = 0;
            if (index != -1)
            {
                cummulativeProb = listBox3.Items.Count == 0 ? 0 : system.Servers[index].TimeDistribution[system.Servers[index].TimeDistribution.Count - 1].CummProbability;
            }

            TimeDistribution td2 = new TimeDistribution();
            td2.Time = GetInterarrivalTimeForServer();
            td2.Probability = GetInterarrivalPropForServer();
            td2.MinRange = Convert.ToInt32(cummulativeProb * 100) + 1;
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
            listBox8.Items.Add(td2.MinRange + "-" + td2.MaxRange);

            server_time_field.Clear();
            server_prob_field.Clear();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

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
        public static List<string> FilterLines(List<string> inputLines)
        {
            List<string> filteredLines = new List<string>();

            foreach (string line in inputLines)
            {
                // Use Regex.IsMatch to check if the line consists of digits only
                if (Regex.IsMatch(line, @"^\d+$"))
                {
                    filteredLines.Add(line);
                }
                else if (Regex.IsMatch(line, @"^\d+,\s\d+(\.\d+)?$"))
                {
                    // Keep lines with the specified format (e.g., "1, 0.25")
                    filteredLines.Add(line);
                }
            }

            return filteredLines;
        }
        private void button2_Click(object sender, EventArgs e) // Upload Input File
        {
            //system = new SimulationSystem();
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = @"C:\txt";
            file.Title = "Open a file to read data";
            file.Filter = "Text files only (*.txt) | *.txt";
            file.DefaultExt = "txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                var fileLocation = File.ReadAllLines(file.FileName);
                List<string> input = new List<string>(fileLocation);
                List<string> lines = new List<string>();
                lines = FilterLines(input); //Lines Filteration

                system.NumberOfServers = int.Parse(lines[0]);
                system.StoppingNumber = int.Parse(lines[1]);
                system.StoppingCriteria = (Enums.StoppingCriteria)int.Parse(lines[2]);
                system.SelectionMethod = (Enums.SelectionMethod)int.Parse(lines[3]);

                //Number of lines in each distribution 
                int linesForEachDistribution = (lines.Count - 3) / (system.NumberOfServers + 1);// can NOT process Test case 3

                decimal cummulativeProb = 0;
                for (int i = 4; i < 4 + linesForEachDistribution; i++)
                {
                    string[] parts = lines[i].Split(',');
                    TimeDistribution t = CreateTimeDistribution(int.Parse(parts[0].Trim()), decimal.Parse(parts[1].Trim()), ref cummulativeProb);
                    system.InterarrivalDistribution.Add(t);
                }

                Dictionary<int, Dictionary<int, double>> serviceDistributions = new Dictionary<int, Dictionary<int, double>>();
                int lineIndex = 4 + linesForEachDistribution;
                for (int serverIndex = 1; serverIndex <= system.NumberOfServers; serverIndex++)
                {
                    cummulativeProb = 0;
                    Server myNewServer = new Server();
                    myNewServer.ID = serverIndex;
                    while (cummulativeProb < 1 && lineIndex < lines.Count)
                    {
                        string[] parts = lines[lineIndex].Split(',');
                        TimeDistribution t = CreateTimeDistribution(int.Parse(parts[0].Trim()), decimal.Parse(parts[1].Trim()), ref cummulativeProb);
                        myNewServer.TimeDistribution.Add(t);
                        lineIndex++;
                    }
                    system.Servers.Add(myNewServer);
                }
            }
            //file.FileName[file.FileName.Length - 13, file.FileName.Length - 4];
            //string[] fileName = file.FileName.Split('/');
            //string actualName = fileName[fileName.Length - 1];
            actualPath = file.FileName;
            Debug.WriteLine(actualPath);

            DrawTable();
        }


        public void DrawChart()
        {
            Chart chart = new Chart();

            Series series = new Series();

            series.Points.Add(new DataPoint(1, 1));
            series.Points.Add(new DataPoint(2, 1));
            series.Points.Add(new DataPoint(3, 0));
            series.Points.Add(new DataPoint(4, 1));
            series.Points.Add(new DataPoint(5, 0));

            chart.Series.Add(series);

            chart.Titles.Add("My Chart");
            chart.ChartAreas[0].AxisX.Title = "X Axis";
            chart.ChartAreas[0].AxisY.Title = "Y Axis";

            chart.Show();
        }
        private void button4_Click(object sender, EventArgs e) // RUN
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

            DrawChart();

        }
        List<(int, int)> availableServers = new List<(int, int)>();
        List<(int, int)> busyServers = new List<(int, int)>();
        public (int, int) CheckForServer(int arrivalTime, int index)
        {
            availableServers.Clear();
            busyServers.Clear();
            //Based on Priority 
            for (int i = 0; i < system.Servers.Count; i++)
            {
                if (system.Servers[i].FinishTime <= arrivalTime)
                {
                    availableServers.Add((system.Servers[i].ID, system.Servers[i].FinishTime));
                    system.Servers[i].Graph.Add((index, 1));
                }
                else if (system.Servers[i].FinishTime > arrivalTime)
                {
                    busyServers.Add((system.Servers[i].ID, system.Servers[i].FinishTime));
                    system.Servers[i].Graph.Add((index, 0));
                }
            }
            if (availableServers.Count != 0)// based on Priority
            {
                availableServers.Sort((x, y) => x.Item1.CompareTo(y.Item1));
                return (availableServers[0].Item1, availableServers[0].Item2);
            }
            else if (busyServers.Count != 0) // Check if busyServers has elements
            {
                busyServers.Sort((x, y) => x.Item2.CompareTo(y.Item2));
                return (busyServers[0].Item1, busyServers[0].Item2);
            }
            else
            {
                return (0, 0);
            }
        }



        public int MappingInServerlDistribution(int randomNum2, int id) // get service time
        {
            int indexer = id - 1; // Adjust index to match the server ID
            if (indexer >= 0 && indexer < system.Servers.Count) // Check if indexer is within the valid range
            {
                foreach (var timeDistribution in system.Servers[indexer].TimeDistribution)
                {
                    if (randomNum2 >= timeDistribution.MinRange && randomNum2 <= timeDistribution.MaxRange)
                    {
                        return timeDistribution.Time;
                    }
                }
            }
            return 1;
        }

        private void DrawTable()
        {
            Form tableView = new Form();
            tableView.Width = 1150;
            tableView.Height = 800;
            DataGridView data = new DataGridView();
            data.Dock = DockStyle.Fill;


            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            columnHeaderStyle.BackColor = Color.White;
            columnHeaderStyle.Font = new Font("Monospace", 8, FontStyle.Bold);
            data.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            data.ColumnHeadersVisible = true;
            string[] columns = new string[] { "Customer No.", "Random Digits for Arrival", "Time between Arrivals", "Clock Time of Arrival", "Random Digits for Service", "Time Service Begins", "Service Time", "Time Service Ends", "Time in Queue", "Server Index" };
            data.ColumnCount = columns.Length;
            for (int i = 0; i < columns.Length; i++)
            {
                data.Columns[i].Name = columns[i];
            }
            int ArrivalTime = 0;
            Random randomNum = new Random();
            for (int i = 1; i <= system.StoppingNumber; i++)
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




                if (i == 1)
                {
                    num = 0;
                    timeBetweenArrival = 0;
                }
                ArrivalTime += timeBetweenArrival;


                //Server
                int serviceBegin = 0, serviceEnd = 0, serviceTime = 0, queueTime = 0, serverIndex = 1;


                //////////////////////////////////
                serverIndex = CheckForServer(ArrivalTime, i).Item1;

                //Service Info
                serviceBegin = Math.Max(CheckForServer(ArrivalTime, i).Item2, ArrivalTime);
                serviceTime = MappingInServerlDistribution(num2, serverIndex);
                serviceEnd = serviceTime + serviceBegin;

                //Queue Time
                if (serviceBegin > ArrivalTime)
                    queueTime = serviceBegin - ArrivalTime;
                else
                    queueTime = 0;

                //Setting the finish time for server
                system.Servers[serverIndex - 1].FinishTime = serviceEnd;
                system.Servers[serverIndex - 1].TotalWorkingTime += serviceTime;
                system.Servers[serverIndex - 1].CustomersServedCount++;


                string[] theData = new string[]
                {
                    i.ToString(),
                    num.ToString(),
                    timeBetweenArrival.ToString(),
                    ArrivalTime.ToString(),
                    num2.ToString(),


                    serviceBegin.ToString(),//time service begin 
                    serviceTime.ToString(),//service time : mapping in server distribution
                    serviceEnd.ToString(),//time service end : time service begin + service time
                    queueTime.ToString(),//time in queue : smallest end time in all servers - time of arrival(accumulationThing)
                    serverIndex.ToString()//server index : based on pirority then idelitiy
                };


                /*if(maxDictSize < queueStuff.Count())
                {
                    maxDictSize = queueStuff.Count();
                }*/

                totalQueueTime += queueTime;
                if (queueTime > 0)
                {
                    maxQueue++;
                    customersWhoWaited++;
                    queueStuff[serviceBegin] = queueTime;
                }
                else
                {
                    maxQueueList.Add(maxQueue);
                    maxQueue = 0;
                }



                List<int> keysToRemove = new List<int>();
                foreach (KeyValuePair<int, int> kvp in queueStuff)
                {
                    if (serviceBegin >= kvp.Key + kvp.Value)
                    {
                        keysToRemove.Add(kvp.Key);
                    }
                }

                foreach (int key in keysToRemove)
                {
                    queueStuff.Remove(key);
                }
                maxDictSize = maxDictSize < queueStuff.Count ? queueStuff.Count : maxDictSize;

                if (i == 1)
                {
                    theData[1] = "-";
                    theData[2] = "-";
                    num = 1;
                }
                endTimes.Add(serviceEnd);
                data.Rows.Add(theData);
                SimulationCase aCase = new SimulationCase(i,
                                                          num,
                                                          timeBetweenArrival,
                                                          ArrivalTime,
                                                          num2,
                                                          serviceTime,
                                                          system.Servers[serverIndex - 1],
                                                          serviceBegin,
                                                          serviceEnd,
                                                          queueTime);
                system.SimulationTable.Add(aCase);
            }



            foreach (Server server in system.Servers)
            {
                if (server.CustomersServedCount == 0)
                {
                    server.CustomersServedCount = 1;
                }
                server.AverageServiceTime = (decimal)server.TotalWorkingTime / (decimal)server.CustomersServedCount;
                server.IdleProbability = (decimal)(endTimes.Max() - server.TotalWorkingTime) / (decimal)endTimes.Max();
                server.Utilization = (decimal)server.TotalWorkingTime / (decimal)system.SimulationTable[system.SimulationTable.Count - 1].EndTime;
            }

            tableView.Controls.Add(data);
            tableView.ShowDialog();

            PerformanceTesting();

            string[] theActualPath = actualPath.Split('\\');
            //Debug.WriteLine(theActualPath[theActualPath.Length-1]);
            string fileName = theActualPath[theActualPath.Length - 1];
            char index = fileName[8];
            string result = "";
            if(index == '1')
                result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            else if (index == '2')
                result = TestingManager.Test(system, Constants.FileNames.TestCase2);
            else if (index == '3')
                result = TestingManager.Test(system, Constants.FileNames.TestCase3);
            else if (index == '4')
                result = TestingManager.Test(system, Constants.FileNames.TestCase4);
            else if (index == '5')
                result = TestingManager.Test(system, Constants.FileNames.TestCase5);


            MessageBox.Show(result);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
        }

        private void clear_server_Click(object sender, EventArgs e)
        {
            int index = system.Servers.FindIndex(item => item.ID == int.Parse(id_field.Text) - 1);
            if (index != -1)
            {
                system.Servers.RemoveAt(index);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < system.Servers.Count; i++)
            {
                Form chartView = new Form();
                chartView.Width = 1200;
                chartView.Height = 700;
                chartView.Text = "Server " + system.Servers[i].ID;
                // Create a Chart control
                Chart chart = new Chart();
                chart.Width = 1200;
                chart.Height = 450;

                // Add the chart to the form
                chartView.Controls.Add(chart);

                // Create a ChartArea and add it to the chart
                ChartArea chartArea = new ChartArea("MyChartArea");
                chart.ChartAreas.Add(chartArea);

                // Create a Series and add data points to the series
                Series series = new Series("MySeries");

                for (int j = 0; j < system.Servers[i].Graph.Count; j++)
                {
                    series.Points.AddXY(system.Servers[i].Graph[j].Item1, system.Servers[i].Graph[j].Item2);
                }

                // Add the series to the chart
                chart.Series.Add(series);

                // Customize the chart as needed
                // Customize the X-axis
                chartArea.AxisX.Title = "X Axis";
                chartArea.AxisX.MajorGrid.Enabled = false; // Hide major gridlines

                foreach (var dataPoint in system.Servers[i].Graph)
                {
                    chartArea.AxisX.CustomLabels.Add(dataPoint.Item1 - 0.5, dataPoint.Item1 + 0.5, dataPoint.Item1.ToString());
                }

                // Customize the Y-axis
                chartArea.AxisY.Title = "Y Axis";
                chartArea.AxisY.Minimum = 0; // Set the minimum value
                chartArea.AxisY.Maximum = 1.2; // Set the maximum value
                chartArea.AxisY.Interval = 1; // Set the interval


                Label averageServiceTimePerServer = new Label();
                TextBox averageServiceTimePerServerTextBox = new TextBox();

                Label idleProbability = new Label();
                TextBox idleProbabilityTextBox = new TextBox();



                // Set label text
                averageServiceTimePerServer.Text = "Average Service Time:";
                idleProbability.Text = "Idle Probability:";

                // Set text box values (you can fetch these values from your calculations)
                averageServiceTimePerServerTextBox.Text = system.Servers[i].AverageServiceTime.ToString();
                idleProbabilityTextBox.Text = system.Servers[i].IdleProbability.ToString();

                // Set the location and size of the controls
                averageServiceTimePerServer.Location = new Point(10, 500);
                averageServiceTimePerServerTextBox.Location = new Point(150, 500);

                idleProbability.Location = new Point(10, 550);
                idleProbabilityTextBox.Location = new Point(150, 550);



                // Add controls to the form
                chartView.Controls.Add(averageServiceTimePerServer);
                chartView.Controls.Add(averageServiceTimePerServerTextBox);

                chartView.Controls.Add(idleProbability);
                chartView.Controls.Add(idleProbabilityTextBox);
                // Show the form
                // Show the chart in an independent window
                chartView.ShowDialog();

            }

        }

        private void PerformanceTesting()
        {
            system.PerformanceMeasures.AverageWaitingTime = (decimal)totalQueueTime / (decimal)system.StoppingNumber;
            system.PerformanceMeasures.MaxQueueLength = maxDictSize;
            system.PerformanceMeasures.WaitingProbability = (decimal)customersWhoWaited / (decimal)system.StoppingNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form performance = new Form();
            performance.Width = 400;
            performance.Height = 200;
            performance.Text = "Performance Measures";

            // Create labels and text boxes
            Label averageWaitingTimeLabel = new Label();
            TextBox averageWaitingTimeTextBox = new TextBox();

            Label maxQueueLengthLabel = new Label();
            TextBox maxQueueLengthTextBox = new TextBox();

            Label waitingProbabilityLabel = new Label();
            TextBox waitingProbabilityTextBox = new TextBox();

            // Set label text
            averageWaitingTimeLabel.Text = "Average Waiting Time:";
            maxQueueLengthLabel.Text = "Max Queue Length:";
            waitingProbabilityLabel.Text = "Waiting Probability:";

            // Set text box values (you can fetch these values from your calculations)
            averageWaitingTimeTextBox.Text = system.PerformanceMeasures.AverageWaitingTime.ToString();
            maxQueueLengthTextBox.Text = system.PerformanceMeasures.MaxQueueLength.ToString();
            waitingProbabilityTextBox.Text = system.PerformanceMeasures.WaitingProbability.ToString();

            // Set the location and size of the controls
            averageWaitingTimeLabel.Location = new Point(10, 10);
            averageWaitingTimeTextBox.Location = new Point(150, 10);

            maxQueueLengthLabel.Location = new Point(10, 40);
            maxQueueLengthTextBox.Location = new Point(150, 40);

            waitingProbabilityLabel.Location = new Point(10, 70);
            waitingProbabilityTextBox.Location = new Point(150, 70);

            // Add controls to the form
            performance.Controls.Add(averageWaitingTimeLabel);
            performance.Controls.Add(averageWaitingTimeTextBox);
            performance.Controls.Add(maxQueueLengthLabel);
            performance.Controls.Add(maxQueueLengthTextBox);
            performance.Controls.Add(waitingProbabilityLabel);
            performance.Controls.Add(waitingProbabilityTextBox);

            // Show the form
            performance.ShowDialog();
        }
    }
}


