using lab_work_uni;

namespace lab_work_uni_csharp
{
    public class Model
    {
        private SystemClock _clock;
        private Resource _cpu;
        private Resource _device;
        private Memory _ram;
        private IdGenerator? _id;
        private PriorityQueue<Process, long> _readyQueue;
        private Queue<Process> _deviceQueue;
        private CPUScheduler? _cpuScheduler;
        private MemoryManager _memoryManager;
        private DeviceScheduler _deviceScheduler;
        private Random _processRand;
        private Settings _settings;


        public Model() 
        { 
            _clock = new SystemClock();
            _cpu = new Resource();
            _device = new Resource();
            _ram = new Memory();
            _memoryManager = new MemoryManager();
            _processRand = new Random();
            _settings = new Settings();
            if (_readyQueue != null)
            {
                _cpuScheduler = new CPUScheduler(_cpu, _readyQueue);
                _id = new IdGenerator();
            }

            _readyQueue = new PriorityQueue<Process, long>();
            _deviceQueue = new Queue<Process>();
            _deviceScheduler = new DeviceScheduler(_device, _deviceQueue);

        }


       public void SaveSettings()
        {
            _ram.Save(_settings.ValueOfRamSize);


            _memoryManager = new MemoryManager();
            
        }

       public void WorkingCycle()
        {
            
            _clock.Working();
            
            if (_processRand.NextDouble() <= _settings.Intensity)
            {
                if (_id != null)
                {
                    Process proc = new Process(_id.Id, 
                        _processRand.Next(_settings.MinValueOfAddrSpace, _settings.MaxValueOfAddrSpace + 1));
                    if (_memoryManager.Allocate(proc) != null)
                    {
                        proc.BurstTime = _processRand.Next(_settings.MinValueOfBurstTime, _settings.MaxValueOfBurstTime + 1);
                  
                        _readyQueue.Enqueue(proc, 1);
                        if (_cpu.IsFree())
                        {
                            _cpuScheduler?.Session();
                        }
                    }
                }
            };
            _cpu.WorkingCycle();
            _device.WorkingCycle();
            }

            
       
        public void Clear()
        {
            _cpu.Clear();

            _device.Clear();

            _ram.Clear();

            _readyQueue.Clear();

            _deviceQueue.Clear();

            _clock.Clear();
        }

        private void FreeingAResourceEventHandler(Process proc)
        {
            Console.WriteLine($"Resource freed for process {proc}");
        }

        private void Subscribe(Process process)
        {
            process.FreeingAResource += FreeingAResourceEventHandler;
        }

        private void Unsubscribe(Process process)
        {
            process.FreeingAResource -= FreeingAResourceEventHandler;
        }
       
    }
}
