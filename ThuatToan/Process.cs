using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuatToan
{
    public  class MyProcess
    {
        private string name_process;
        private double burst_time;
        private double  arrival_time;
        private double priority;
        public double waiting_time { get; set; }
        public double turn_around_time { get; set; }

        public string Name_process
        {
            get { return name_process; }
            set { name_process = value; }
        }
        public double Burst_time
        {
            get { return burst_time; }
            set { burst_time = value; }
        }
        public double Arrival_time
        {
            get { return arrival_time; }
            set { arrival_time = value; }
        }
        public double Priority
        {
            get { return priority; }
            set
            {
                priority = value;
            }   
        }
      
        public MyProcess() { }
        public MyProcess(string process, double bt,double at,double priority)
        {
            Name_process = process;
            Burst_time = bt;
            Arrival_time = at;
            Priority = priority;
        }

        
    }
}
