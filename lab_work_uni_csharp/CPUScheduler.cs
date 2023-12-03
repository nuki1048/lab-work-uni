using System;
using System.Collections.Generic;
using lab_work_uni_csharp;


namespace lab_work_uni
{
    public class CPUScheduler
    {
     

        private Resource _resource;
        private PriorityQueue<Process, long> queue;
        
        public CPUScheduler(Resource resource, PriorityQueue<Process, long> queue)
        {
            this._resource = resource;
            this.queue = queue;
        }
        public PriorityQueue<Process, long> Session()
        {
            _resource.ActiveProcess = queue.Dequeue();
            _resource.ActiveProcess.Status = ProcessStatus.Running;
            return queue;
        }
    }

   
}