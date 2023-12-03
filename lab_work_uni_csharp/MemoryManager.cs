using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    class MemoryManager
    {
        
        public void Save(Memory ramMemory)
        {
            this._memory = ramMemory;
        }

        public Memory Allocate(long size)
        {
            if (size > _memory.FreeSize) return null!;
            _memory.OccupiedSize += size;
            return _memory;
        }

        public Memory Free(long size)
        {
            _memory.OccupiedSize -= size;
            return _memory;
        }

        private Memory _memory;
    }
}