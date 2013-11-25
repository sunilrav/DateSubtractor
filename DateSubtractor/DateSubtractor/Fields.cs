using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DateSubtractor
{
    public class Fields : INotifyPropertyChanged
    {
        private DateTime startDate;
        public DateTime StartDate { 
            get { return startDate; }
            set 
            { 
                startDate = value;
                OnPropertyChanged();
            } 
        }

        private int numDays;
        public int NumDays
        {
            get { return numDays; }
            set
            {
                numDays = value;
                OnPropertyChanged();
            }
        }

        private DateTime resultDate;
        public DateTime ResultDate
        {
            get { return resultDate; }
            set
            {
                resultDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                   new PropertyChangedEventArgs(caller));
            }
        }

    }
}
