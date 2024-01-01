using Clock.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Input;

namespace Clock.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _Pomodoro;
        private object _StopWatch;

        private Visibility _Pomodoro_Visibility;
        private Visibility _StopWatch_Visibility;

        public Visibility Pomodoro_Visibility { get => _Pomodoro_Visibility; set { _Pomodoro_Visibility = value; OnPropertyChanged(); } }
        public Visibility StopWatch_Visibility { get => _StopWatch_Visibility; set { _StopWatch_Visibility = value; OnPropertyChanged(); } }
        public object Pomodoro
        {
            get { return _Pomodoro; }
            set { _Pomodoro = value; OnPropertyChanged(); }
        }

        public object StopWatch
        {
            get { return _StopWatch; }
            set { _StopWatch = value; OnPropertyChanged(); }
        }

        public ICommand PomodoroCommand { get; set; }
        public ICommand TimerCommand { get; set; }
        public ICommand AlarmCommand { get; set; }
        public ICommand StopwatchCommand { get; set; }


        public NavigationVM()
        {
            Pomodoro = new PomodoroVM();
            StopWatch = new StopwatchVM();
            Pomodoro_Visibility = Visibility.Visible;
            StopWatch_Visibility = Visibility.Hidden;

            PomodoroCommand = new RelayCommand((p) =>
            {
                if(Pomodoro_Visibility == Visibility.Visible)
                {
                    Pomodoro_Visibility = Visibility.Hidden;
                    StopWatch_Visibility = Visibility.Visible;
                }
                else if(Pomodoro_Visibility == Visibility.Hidden)
                {
                    Pomodoro_Visibility = Visibility.Visible;
                    StopWatch_Visibility = Visibility.Hidden;
                }
            }, (p) =>
            {
                return true;
            });
            StopwatchCommand = new RelayCommand((p) =>
            {
                if (StopWatch_Visibility == Visibility.Visible)
                {
                    StopWatch_Visibility = Visibility.Hidden;
                    Pomodoro_Visibility = Visibility.Visible;
                }
                else if (StopWatch_Visibility == Visibility.Hidden)
                {
                    StopWatch_Visibility = Visibility.Visible;
                    Pomodoro_Visibility = Visibility.Hidden;
                }
            }, (p) =>
            {
                return true;
            });
            // Startup Page

        }
    }
}
