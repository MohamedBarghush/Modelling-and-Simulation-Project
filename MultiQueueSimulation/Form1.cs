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
            decimal cummulativeProp = 1;
            TimeDistribution interArrivalDistribution = new TimeDistribution();
            interArrivalDistribution.Time = GetInterarrivalTime();
            interArrivalDistribution.Probability = GetInterarrivalProp();
            interArrivalDistribution.MinRange = Convert.ToInt32(cummulativeProp * 100);
            cummulativeProp += GetInterarrivalProp();
            interArrivalDistribution.CummProbability = cummulativeProp;
            interArrivalDistribution.MaxRange = Convert.ToInt32(cummulativeProp * 100);
            system.InterarrivalDistribution.Add(interArrivalDistribution);
        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public SimulationSystem GetSystem ()
        {
            return system;
        }
    }
}
