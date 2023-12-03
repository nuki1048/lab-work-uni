using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public enum ProcessStatus { Ready, Running, Waiting, Terminated }

    public delegate void ProcessDelegate(Process proc);

    public class Process
    {
        public Process(long pId, long addrSpace)
        {
            _id = pId;
            _name = "P" + pId.ToString();
            Status = ProcessStatus.Ready;
            this.AddrSpace = addrSpace;
        }
        public void IncreaseWorkTime()
        {
            if (_workTime == BurstTime) 
            {
                if (Status == ProcessStatus.Running)
                {
                    Status = _procRand.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting; 
                }
                else 
                {
                    Status = ProcessStatus.Ready;
                    OnFreeingAResource();
                }
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
            return "Process Id = " + _id.ToString() + "; BurstTime = " + BurstTime.ToString() + "; WorkTime = " + _workTime.ToString();
        }

        private long _id;
        private string _name;
        private long _workTime;
        private long _addrSpace;

        private Random _procRand = new Random();

        public long BurstTime
        {
            get; 
            set; 
        }
        public long AddrSpace
        {
            get;
            set; 
        }
        public ProcessStatus Status
        {
            get; 
            set; 
        }

        public event ProcessDelegate FreeingAResource;

       

        private void OnFreeingAResource()
        {
            FreeingAResource?.Invoke(this);
        }

    }
}
