using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace lab_work_uni_csharp
{
    public class Memory
    {
        
        
      
        public long OccupiedSize
        {
            get;
            set;
        }
        
        
        public long FreeSize
        {
            get;
            set;
        }
        

        private long occupiedSize;
        private long freeSize;


        public void Save(long size)
        {
            this.FreeSize = size;
            this.OccupiedSize = 0;
            
        }
        
        public void Clear()
        {
            this.occupiedSize = 0;
        }

    }
}