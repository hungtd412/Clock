using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Clock.Model.StopWatchModel;
using Clock.Utilities;

namespace Clock.ViewModel
{
    public class StopwatchVM : Utilities.ViewModelBase
    {
        private StopWatch stopwatch;

        private string _TimeDisplay;

        public string TimeDisplay { get => _TimeDisplay; set { _TimeDisplay = value; OnPropertyChanged(); } }
        
        public ICommand StartCommand { get; set; }

        public StopwatchVM() 
        {
            stopwatch = new();
            TimeDisplay = stopwatch.StartTime;

            StartCommand = new RelayCommand();
        }
    }
}
