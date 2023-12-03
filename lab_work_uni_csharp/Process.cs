using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public enum ProcessStatus { Ready, Running, Waiting, Terminated }

    public class Process
    {
        public Process(long pId, long addrSpace)
        {
            id = pId;
            name = "P" + pId.ToString();
            Status = ProcessStatus.Ready;
            this.AddrSpace = addrSpace;
        }
        public void IncreaseWorkTime()
        {
            if (workTime == BurstTime) 
            {
                if (Status == ProcessStatus.Running)
                {
                    Status = procRand.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting; 
                }
                else
                {
                    Status = ProcessStatus.Ready; 
                }
            }
            else
            {
                workTime++;
            }
        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public override string ToString()
        {
            return "Process Id = " + id.ToString() + "; BurstTime = " + BurstTime.ToString() + "; WorkTime = " + workTime.ToString();
        }

        private long id;
        private string name;

        private long workTime;
        private long addrSpace;
        
        private Random procRand = new Random();

        public long BurstTime
        {
            get;
            set; 
        }
        public long AddrSpace
        {
            get; 
            private set; 
        }
        public ProcessStatus Status
        {
            get; 
            set; 
        }
    }
}
