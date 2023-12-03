namespace lab_work_uni_csharp
{
    public class SystemClock
    {

        public SystemClock(long clock)
        {
            this._clock = clock;
        }

    
        private long Clock
        {
            get;
            set;
        }

        private long _clock;

        public SystemClock()
        {
            throw new NotImplementedException();
        }


        public void Working()
        {
            _clock++;
        }

        public void Clear()
        {
            Clock = 0;
        }
    }
}