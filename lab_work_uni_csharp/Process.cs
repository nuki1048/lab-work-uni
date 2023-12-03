using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public enum ProcessStatus
    {
        Ready,
        Running,
        Waiting,
        Terminated
    }

    public class Process: IComparable<Process>
    {
        public Process(long pid, long addrSpace)
        {
            _id = pid;
            AddrSpace = addrSpace;           
            _name = "P" + pid.ToString();

            Status = ProcessStatus.Ready;
        }

        public void IncreaseWorkTime()
        {
            if (_workTime==BurstTime)
            {
                if (Status == ProcessStatus.Running)
                {
                    Status = _random.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
                  
                }
                else
                {
                    Status = ProcessStatus.Ready;
                }
                OnFreeingAResource();
            }
            else
            {
                _workTime++;
            }
            
        }
        public void ResetWorkTime()
        {
            _workTime = 0;
        }

        public override string ToString()
        {
            string result = "Id: " + _id.ToString() + " Name: " + _name + " Status: " + Status + " BurstTime: " + BurstTime + " AddrSpace: " + AddrSpace;
            return result;
        }

        public int CompareTo(Process? other)
        {
            return other == null ? 1 : other.BurstTime.CompareTo(this.BurstTime);
        }

        private void OnFreeingAResource()
        {
            FreeingAResource(this, null!);
        }

        private long _id;
        private string _name;
        private long _workTime;

        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }    
        public long ReadyQueueArrivalTime { get; set; }
        public long AddrSpace { get; private set; }
        public long ArrivalTime { get; set; }
        public long CommonWaitingTime { get; set; }
        
        public event EventHandler FreeingAResource ;
        private Random _random = new Random();
    }
}
