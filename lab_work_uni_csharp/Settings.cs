using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    class Settings
    {
        private double _intensity;
        private int _minvalueOfBurstTime;
        private int _maxvalueOfBurstTime;
        private int _minvalueOfAddrSpace;
        private int _maxvalueOfAddrSpace;
        private int _valueofRamSize;




        public double Intensity { get; set; }
        public int MinValueOfBurstTime { get; set; }
        public int MaxValueOfBurstTime { get; set; }
        public int MinValueOfAddrSpace { get; set; }
        public int MaxValueOfAddrSpace { get; set; }
        public int ValueOfRamSize { get; set; }

        //TODO: a temporary stub until you repeat the request to Form
        public Settings()
        {
            Intensity = 0.6;
            MinValueOfBurstTime = 2;
            MaxValueOfBurstTime = 6;
            MinValueOfAddrSpace = 100;
            MaxValueOfAddrSpace = 300;
            ValueOfRamSize = 4096;
        }


    }
}