using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace lab_work_uni_csharp
{
    class Model: INotifyPropertyChanged
    {

        public Model()
        {
            Clock = new SystemClock();
            Cpu = new Resource();
            Ram = new Memory();
            Device = new Resource();
            _id = new IdGenerator();
            _readyQueue = new Queue<Process>(new SortedSet<Process>());

            _deviceQueue = new Queue<Process>();
            _cpuScheduler = new CpuScheduler(Cpu, _readyQueue);
            _memoryManager = new MemoryManager();
            _deviceScheduler = new DeviceScheduler(Device, _deviceQueue);
            ModelSettings = new Settings();
            _processRand = new Random();
        }

        public void SaveSettings()
        {
            Ram.Save(ModelSettings.ValueOfRamSize);
            _memoryManager.Save(Ram);
        }

        public void WorkingCycle() 
        {
            Clock.Working();
            double c = _processRand.NextDouble();
            
            if (c <= ModelSettings.Intensity)
            {
                Process proc = new Process(_id.Id, _processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1));

                if (_memoryManager.Allocate(proc.AddrSpace) != null)
                {
                    proc.ArrivalTime = Clock.Clock;
                    proc.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    _readyQueue.Enqueue(proc);

                    proc.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.IsFree())
                    {
                        putProcessOnResource(Cpu);
                    }                  
                }
            }
            Cpu.WorkingCycle();
            Device.WorkingCycle();
        }

        public void Clear() 
        {
            Unsubscribe(Cpu);
            Unsubscribe(Device);
            Cpu.Clear();
            Device.Clear();
            Ram.Clear();
            _readyQueue.Clear();
           _deviceQueue.Clear();
            Clock.Clear();
            _id.Clear();
        }


        public readonly SystemClock Clock;       
        public readonly Resource Cpu;
        public readonly Resource Device;
        public readonly Memory Ram;
        private IdGenerator _id;
        private Queue<Process> _readyQueue;
        private Queue<Process> _deviceQueue;
        private CpuScheduler _cpuScheduler;
        private MemoryManager _memoryManager;
        private DeviceScheduler _deviceScheduler;
        private Random _processRand;
        public readonly Settings ModelSettings;
        public Queue<Process> ReadyQueue
        {
            get
            {
                return _readyQueue;
            }
            set
            {
                _readyQueue = value;
                OnPropertyChanged();
            }
        }
          
        public Queue<Process> DeviceQueue
        {
            get
            {
                return _deviceQueue;
            }
            set
            {
                _deviceQueue = value;
                OnPropertyChanged();
            }
        }
        
        private void Subscribe(Resource resource)
        {
            resource.ActiveProcess.FreeingAResource += FreeingAResourceEventHandler;
        }

        private void Unsubscribe(Resource resource)
        {
            resource.ActiveProcess.FreeingAResource -= FreeingAResourceEventHandler;
        }
        private void putProcessOnResource(Resource resource)
        {
            if(resource == Cpu)
            {
                ReadyQueue = _cpuScheduler.Session();
                resource.ActiveProcess.CommonWaitingTime += (Clock.Clock - resource.ActiveProcess.ReadyQueueArrivalTime);
            }
            else
            {
                DeviceQueue = _deviceScheduler.Session();
            }
            Subscribe(resource);
        }
        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process resourceFreeingProcess = sender as Process ?? throw new InvalidOperationException();


            Debug.Assert(resourceFreeingProcess != null, nameof(resourceFreeingProcess) + " != null");
            switch (resourceFreeingProcess.Status)
            {
                case ProcessStatus.Terminated:
                    Unsubscribe(Cpu);
                    Cpu.Clear(); 
                    _memoryManager.Free(resourceFreeingProcess.AddrSpace);
                    if (_readyQueue.Count != 0)
                    {
                        putProcessOnResource(Cpu);
                    }                                              
                    break;
                case ProcessStatus.Waiting:
                    Unsubscribe(Cpu);
                    Cpu.Clear();
                    if (_readyQueue.Count != 0)
                    {
                        putProcessOnResource(Cpu);
                    }                   
                    
                    resourceFreeingProcess.ResetWorkTime();

                    resourceFreeingProcess.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    DeviceQueue.Enqueue(resourceFreeingProcess);
                    if (Device.IsFree())
                    {
                        putProcessOnResource(Device);
                    }
                    break;

                case ProcessStatus.Ready:
                    Unsubscribe(Device);
                    Device.Clear();
                    if (_deviceQueue.Count != 0)
                    {
                        putProcessOnResource(Device);
                    }
                    resourceFreeingProcess.ResetWorkTime();
                    resourceFreeingProcess.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    _readyQueue.Enqueue(resourceFreeingProcess);
                    resourceFreeingProcess.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.IsFree())
                    {
                        putProcessOnResource(Cpu);
                    }
                    break;
                default:
                    throw new Exception("Unknown process status");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}