using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace lab_work_uni_csharp
{
    public class Resource
    {
        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess?.IncreaseWorkTime();
            }
        }
        [Pure]
        public bool IsFree()
        {
            return activeProcess == null;
        }
        public void Clear()
        {
            activeProcess = null;
        }

        public Process ActiveProcess
        {
            get;
            set;
        }

        private Process? activeProcess = null;
        
    }
}