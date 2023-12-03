using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_work_uni_csharp
{
    public class Settings
    {
        private double _intensity;
        private int _minValueOfBurstTime;
        private int _maxValueOfBurstTime;
        private int _minValueOfAddrSpace;
        private int _maxValueOfAddrSpace;
        private int _valueOfRamSize;
        public double Intensity
        {
            get;
            set;
        }
        public int MinValueOfBurstTime { 
            get;
            set;
        }
        public int MaxValueOfBurstTime
        {
            get;
            set;

        }
        public int MinValueOfAddrSpace
        {
            get;
            set;

        }
        public int MaxValueOfAddrSpace
        {
            get;
            set;

        }
        public int ValueOfRamSize
        {
            get;
            set;
        }
    }
}