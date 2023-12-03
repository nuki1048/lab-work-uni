using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public class MemoryManager
    {
        private Memory _memory;

        public void Save(Memory ramMemory)
        {
            this._memory = ramMemory;
        }

        public  Memory Allocate(Process process)
        {
            if (_memory.FreeSize >= process.AddrSpace)
            {
               
                
                _memory.OccupiedSize += process.AddrSpace; 
                return _memory;
            }
            else
            {
                return null; 
            }
        }
        public void Free(Memory? ramMemory, Process? process)
        {
            if (ramMemory == null || process == null) return;
            ramMemory.Clear();
            this._memory.OccupiedSize -= process.AddrSpace;
        }
    }

   
}