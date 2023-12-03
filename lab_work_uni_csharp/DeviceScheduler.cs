using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public class DeviceScheduler
    {
        private Resource _resource;
        private Queue<Process> _queue;

        public DeviceScheduler(Resource resource, Queue<Process> queue)
        {
            this._resource = resource;
            this._queue = queue;
        }
        public Queue<Process> Session()
        {
            _resource.ActiveProcess = _queue.Dequeue();
            return _queue;
        }
    }
}