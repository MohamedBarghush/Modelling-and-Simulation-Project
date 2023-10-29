using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
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

        private List<string> InterarrivalTime = new List<string>();
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


        public int GetInterarrivalTimeForServer()
        {
            return Int32.Parse(serviceTimeServer.Text);
        }

        public decimal GetInterarrivalPropForServer()
        {
            return Decimal.Parse(probabilityServer.Text);
        }





        public TimeDistribution GetTimeDistribution()
        {
            return interArrivalDistribution;
        }

        private void add_Click(object sender, EventArgs e)
        {
            decimal cummulativeProp = 1;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            interArrivalDistribution.Time = GetInterarrivalTime();
            interArrivalDistribution.Probability = GetInterarrivalProp();
            interArrivalDistribution.MinRange = Convert.ToInt32(cummulativeProp * 100);
            cummulativeProp += GetInterarrivalProp();
            interArrivalDistribution.CummProbability = cummulativeProp;
            interArrivalDistribution.MaxRange = Convert.ToInt32(cummulativeProp * 100);
            system.InterarrivalDistribution.Add(interArrivalDistribution);

            listBox1.Items.Add(GetInterarrivalTime());
            listBox2.Items.Add(GetInterarrivalProp());

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

        public SimulationSystem GetSystem ()
        {
            return system;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal cummulativeProp = 1;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            interArrivalDistribution.Time = GetInterarrivalTime();
            interArrivalDistribution.Probability = GetInterarrivalProp();
            interArrivalDistribution.MinRange = Convert.ToInt32(cummulativeProp * 100);
            cummulativeProp += GetInterarrivalProp();
            interArrivalDistribution.CummProbability = cummulativeProp;
            interArrivalDistribution.MaxRange = Convert.ToInt32(cummulativeProp * 100);
            system.InterarrivalDistribution.Add(interArrivalDistribution);

            listBox3.Items.Add(GetInterarrivalTimeForServer());
            listBox4.Items.Add(GetInterarrivalPropForServer());

            serviceTimeServer.Clear();
            probabilityServer.Clear();
        }
    }
}
