namespace lab_work_uni_csharp
{
    public class SystemClock
    {

        public SystemClock(long clock)
        {
            this.clock = clock;
        }

    
        private long Clock
        {
            get;
            set;
        }

        private long clock;


        void WorkingCycle()
        {
            clock++;
        }

        void Clear()
        {
            Clock = 0;
        }
    }
}