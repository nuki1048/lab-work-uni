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
    public class Memory: INotifyPropertyChanged
    {
        
        
        public long Size
        {
            get;
            private set;
        }
        public long OccupiedSize { 
            get => _occupiedSize;
            set {
                _occupiedSize = value;
                FreeSize = Size - _occupiedSize;
                OnPropertyChanged(); 
            } 
        }   
        
        
        public long FreeSize { 
            get => Size - _occupiedSize;
            private set => _occupiedSize = value;
        }
        

        private long _occupiedSize;
        private long _freeSize;


        public void Save(long size)
        {
            this.FreeSize = size;
            this.OccupiedSize = 0;
            
        }
        
        public void Clear()
        {
            this._occupiedSize = 0;
        }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}