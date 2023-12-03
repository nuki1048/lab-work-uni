using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab_work_uni_csharp
{
    public class SystemClock: INotifyPropertyChanged
    {

        public SystemClock(long clock)
        {
            this._clock = clock;
        }

    
        public long Clock { 
            get => _clock;
            private set
            {
                _clock = value;
                OnPropertyChanged();
            }
        }

        private long _clock;

        public SystemClock()
        {
        }


        public void Working()
        {
            _clock++;
        }

        public void Clear()
        {
            Clock = 0;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}