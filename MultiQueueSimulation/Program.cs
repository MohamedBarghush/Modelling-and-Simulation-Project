using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueTesting;
using MultiQueueModels;
using System.Diagnostics;

namespace MultiQueueSimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //SimulationSystem system = new SimulationSystem();
            Form1 form1 = new Form1();
            //system = form1.GetSystem();
            Application.Run(form1);
            
        }
    }
}
