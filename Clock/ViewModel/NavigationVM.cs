using Clock.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Input;

namespace Clock.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand PomodoroCommand { get; set; }
        public ICommand TimerCommand { get; set; }
        public ICommand AlarmCommand { get; set; }
        public ICommand StopwatchCommand { get; set; }

        private void Pomodoro(object obj) => CurrentView = new PomodoroVM();
        private void Timer(object obj) => CurrentView = new TimerVM();
        private void Alarm(object obj) => CurrentView = new AlarmVM();
        private void Stopwatch(object obj) => CurrentView = new StopwatchVM();

        public NavigationVM()
        {
            PomodoroCommand = new RelayCommand(Pomodoro);
            TimerCommand = new RelayCommand(Timer);
            AlarmCommand = new RelayCommand(Alarm);
            StopwatchCommand = new RelayCommand(Stopwatch);
            // Startup Page
            CurrentView = new PomodoroVM();
        }
    }
}
