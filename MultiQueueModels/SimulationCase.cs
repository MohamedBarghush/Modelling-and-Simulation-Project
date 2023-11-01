using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = new Server();
        }

        public SimulationCase(int CustomerNumber, int RandomInterArrival, int InterArrival, int ArrivalTime, int RandomService, int ServiceTime, Server AssignedServer, int StartTime, int EndTime, int TimeInQueue)
        {
            this.CustomerNumber = CustomerNumber;
            this.RandomInterArrival = RandomInterArrival;
            this.InterArrival = InterArrival;
            this.ArrivalTime = ArrivalTime;
            this.RandomService = RandomService;
            this.ServiceTime = ServiceTime;
            this.AssignedServer = AssignedServer;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.TimeInQueue = TimeInQueue;
        }

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServiceTime { get; set; }
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }
    }
}
