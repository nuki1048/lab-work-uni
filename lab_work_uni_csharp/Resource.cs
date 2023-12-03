using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace lab_work_uni_csharp
{
    public class Resource: INotifyPropertyChanged
    {
        
        
        public void WorkingCycle()
        {
            if (!IsFree())
            {
                _activeProcess?.IncreaseWorkTime();
            }
        }
        [Pure]
        public bool IsFree()
        {
            return _activeProcess == null;
        }
        public void Clear()
        {
            _activeProcess = null;
        }

        public Process ActiveProcess { get => _activeProcess;
            set { 
                _activeProcess = value;
                OnPropertyChanged();
            } 
        }

        private Process? _activeProcess = null;
        
        
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}