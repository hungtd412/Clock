using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Clock.View;
using System.Windows.Threading;
using Clock.ViewModel;
using Clock.Model.PomodoroModel;
using System.Windows;
using System.Windows.Input;
using Clock.Utilities;

namespace Clock.ViewModel
{
    public class PomodoroVM : Utilities.ViewModelBase
    {
        private static Pomodoros pomodoro;
        private static DispatcherTimer FocusTimer;
        private static DispatcherTimer BreakTimer;

        private string _FocusTimeDisplay;
        private string _BreakTimeDisplay;
        private string _NumberOfPomodoros;
        private string _CountdownDisplay;

        private bool _IsBreaks;
        private bool _Turn;
        private bool _IsTimes;
        private bool? _BreakTimeCheckButtonEnable;
        private bool? _TimesCheckButtonEnable;

        private Visibility _SettingVisibility;
        private Visibility _CountdownVisibility;

        public ICommand FocusTimeUp {  get; set; }
        public ICommand FocusTimeDown {  get; set; }
        public ICommand BreakTimeUp {  get; set; }
        public ICommand BreakTimeDown {  get; set; }
        public ICommand TimesUp {  get; set; }
        public ICommand TimesDown {  get; set; }
        public ICommand CheckBreaks {  get; set; }
        public ICommand CheckTimes {  get; set; }

        public string FocusTimeDisplay { get => _FocusTimeDisplay; set { _FocusTimeDisplay = value; OnPropertyChanged(); } }
        public string BreakTimeDisplay { get => _BreakTimeDisplay; set { _BreakTimeDisplay = value; OnPropertyChanged(); } }
        public string NumberOfPomodoros { get => _NumberOfPomodoros; set { _NumberOfPomodoros = value; OnPropertyChanged(); } }
        public string CountdownDisplay { get => _CountdownDisplay; set { _CountdownDisplay = value; OnPropertyChanged(); } }

        public bool IsBreaks { get => _IsBreaks; set { _IsBreaks = value; OnPropertyChanged(); } }
        public bool Turn { get => _Turn; set { _Turn = value; OnPropertyChanged(); } }
        public bool IsTimes { get => _IsTimes; set { _IsTimes = value; OnPropertyChanged(); } }
        public bool? BreakTimeCheckButtonEnable { get => _BreakTimeCheckButtonEnable; set { _BreakTimeCheckButtonEnable = value; OnPropertyChanged(); } }
        public bool? TimesCheckButtonEnable { get => _TimesCheckButtonEnable; set { _TimesCheckButtonEnable = value; OnPropertyChanged(); } }

        public Visibility SettingVisibility { get => _SettingVisibility; set { _SettingVisibility = value; OnPropertyChanged(); } }
        public Visibility CountdownVisibility { get => _CountdownVisibility; set { _CountdownVisibility = value; OnPropertyChanged(); } }

        public PomodoroVM()
        {
            pomodoro = new Pomodoros();
            SettingVisibility = Visibility.Visible;
            CountdownVisibility = Visibility.Hidden;

            Turn = true;
            BreakTimeCheckButtonEnable = true;
            TimesCheckButtonEnable = true;

            FocusTimer = new DispatcherTimer();
            FocusTimer.Interval = TimeSpan.FromSeconds(1);
            FocusTimer.Tick += FocusTimer_Tick;

            BreakTimer = new DispatcherTimer();
            BreakTimer.Interval = TimeSpan.FromSeconds(1);
            BreakTimer.Tick += BreakTimer_Tick;

            FocusTimeDisplay = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex].ToString();
            BreakTimeDisplay = pomodoro.BreakTimeList[pomodoro.BreakTimeIndex].ToString();
            NumberOfPomodoros = pomodoro.Times.ToString();

            FocusTimeUp = new RelayCommand((p) =>
            {
                if(pomodoro.FocusTimeIndex < pomodoro.FocusTimeList.Count - 1)
                {
                    pomodoro.FocusTimeIndex++;
                    FocusTimeDisplay = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex].ToString();
                }
            }, (p) =>
            {
                return true;
            });
            FocusTimeDown = new RelayCommand((p) => 
            {
                if (pomodoro.FocusTimeIndex > 0)
                {
                    pomodoro.FocusTimeIndex--;
                    FocusTimeDisplay = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex].ToString();
                }
            }, (p) =>
            {
                return true;
            });

            BreakTimeUp = new RelayCommand((p) => 
            {
                if(pomodoro.BreakTimeIndex < pomodoro.BreakTimeList.Count - 1)
                {
                    pomodoro.BreakTimeIndex++;
                    BreakTimeDisplay = pomodoro.BreakTimeList[pomodoro.BreakTimeIndex].ToString();
                }
            }, (p) => 
            { 
                return true; 
            });
            BreakTimeDown = new RelayCommand((p) =>
            {
                if (pomodoro.BreakTimeIndex > 0)
                {
                    pomodoro.BreakTimeIndex--;
                    BreakTimeDisplay = pomodoro.BreakTimeList[pomodoro.BreakTimeIndex].ToString();
                }
            }, (p) =>
            {
                return true;
            });

            TimesUp = new RelayCommand((p) =>
            {
                if (pomodoro.Times < 10)
                {
                    pomodoro.Times++;
                    NumberOfPomodoros = pomodoro.Times.ToString();
                }
            }, (p) =>
            {
                return true;
            });
            TimesDown = new RelayCommand((p) =>
            {
                if (pomodoro.Times > 2)
                {
                    pomodoro.Times--;
                    NumberOfPomodoros = pomodoro.Times.ToString();
                }
            }, (p) =>
            {
                return true;
            });

            CheckBreaks = new RelayCommand((p) => 
            {
                if (IsBreaks == true)
                {
                    BreakTimeCheckButtonEnable = false;
                }
                else
                {
                    BreakTimeCheckButtonEnable = true;
                }
            }, (p) => 
            {
                return true;
            });
            CheckTimes = new RelayCommand((p) => 
            {
                if(IsTimes == true)
                {
                    TimesCheckButtonEnable = false;
                }
                else
                {
                    TimesCheckButtonEnable= true;
                }
            }, (p) =>
            {
                return true;
            });
        }

        private void BreakTimer_Tick(object? sender, EventArgs e)
        {
            CountdownDisplay = string.Empty;
            if(pomodoro.BreakTime.Minutes == 0 && pomodoro.BreakTime.Seconds == 0)
            {
                BreakTimer.Stop();
                Turn = true;
                pomodoro.BreakTime.Reset();

                FocusTimer.Start();
            }
        }

        private void FocusTimer_Tick(object? sender, EventArgs e)
        {
            CountdownDisplay = string.Empty;
            if (pomodoro.FocusTime.Minutes == 0 && pomodoro.FocusTime.Seconds == 0)
            {
                FocusTimer.Stop();

                if (IsBreaks == true)
                {
                    SettingVisibility = Visibility.Visible;
                    CountdownVisibility = Visibility.Hidden;
                    IsBreaks = false;
                }
                else
                {
                    Turn = false;
                    pomodoro.FocusTime.Reset();
                    if (pomodoro.Times <= 10) pomodoro.Times--;
                    BreakTimer.Start();
                }
            }
            else
            {
                pomodoro.FocusTime.ChangeTime();
                
                CountdownDisplay = pomodoro.FocusTime.TimetoString();
            }
        }
    }
}
