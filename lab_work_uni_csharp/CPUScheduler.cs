namespace lab_work_uni_csharp
{
    public class CpuScheduler
    {
     

        private Resource _resource;
        private Queue<Process> _queue;
        
        public CpuScheduler(Resource resource, Queue<Process> queue)
        {
            this._resource = resource;
            this._queue = queue;
        }
        public Queue<Process> Session()
        {
            _resource.ActiveProcess = _queue.Dequeue();
            _resource.ActiveProcess.Status = ProcessStatus.Running;
            return _queue;
        }
    }

   
}