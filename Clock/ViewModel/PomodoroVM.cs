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
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;
using Clock.Properties;

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
        private string _BtnPauseContent;
        private string _Completed;

        private bool _IsBreaks;
        private bool _Turn;
        private bool _IsTimes;
        private bool? _BreakTimeCheckButtonEnable;
        private bool? _TimesCheckButtonEnable;
        private bool? _BackButtonEnable;

        private Visibility _SettingVisibility;
        private Visibility _CountdownVisibility;

        private ObservableCollection<string> _TasksList;

        private int _DailyGoal;
        private int _Yesterday;
        private int _Streaks;
        private int _PercentGoal;

        public ICommand FocusTimeUp { get; set; }
        public ICommand FocusTimeDown { get; set; }
        public ICommand BreakTimeUp { get; set; }
        public ICommand BreakTimeDown { get; set; }
        public ICommand TimesUp { get; set; }
        public ICommand TimesDown { get; set; }
        public ICommand CheckBreaks { get; set; }
        public ICommand CheckTimes { get; set; }
        public ICommand StartFocus { get; set; }
        public ICommand Pause { get; set; }
        public ICommand Back { get; set; }
        public ICommand Skip { get; set; }
        public ICommand LostFocusFocusTime { get; set; }
        public ICommand WindowMouseDown { get; set; }

        public string FocusTimeDisplay { get => _FocusTimeDisplay; set { _FocusTimeDisplay = value; OnPropertyChanged(); } }
        public string BreakTimeDisplay { get => _BreakTimeDisplay; set { _BreakTimeDisplay = value; OnPropertyChanged(); } }
        public string NumberOfPomodoros { get => _NumberOfPomodoros; set { _NumberOfPomodoros = value; OnPropertyChanged(); } }
        public string CountdownDisplay { get => _CountdownDisplay; set { _CountdownDisplay = value; OnPropertyChanged(); } }
        public string BtnPauseContent { get => _BtnPauseContent; set { _BtnPauseContent = value; OnPropertyChanged(); } }
        public string Completed { get => _Completed; set { _Completed = value; OnPropertyChanged(); } }

        public bool IsBreaks { get => _IsBreaks; set { _IsBreaks = value; OnPropertyChanged(); } }
        public bool Turn { get => _Turn; set { _Turn = value; OnPropertyChanged(); } }
        public bool IsTimes { get => _IsTimes; set { _IsTimes = value; OnPropertyChanged(); } }
        public bool? BreakTimeCheckButtonEnable { get => _BreakTimeCheckButtonEnable; set { _BreakTimeCheckButtonEnable = value; OnPropertyChanged(); } }
        public bool? TimesCheckButtonEnable { get => _TimesCheckButtonEnable; set { _TimesCheckButtonEnable = value; OnPropertyChanged(); } }
        public bool? BackButtonEnable { get => _BackButtonEnable; set { _BackButtonEnable = value; OnPropertyChanged(); } }

        public Visibility SettingVisibility { get => _SettingVisibility; set { _SettingVisibility = value; OnPropertyChanged(); } }
        public Visibility CountdownVisibility { get => _CountdownVisibility; set { _CountdownVisibility = value; OnPropertyChanged(); } }

        public ObservableCollection<string> TasksList { get => _TasksList; set { _TasksList = value; OnPropertyChanged(); } }

        public int DailyGoal { get => _DailyGoal; set { _DailyGoal = value; OnPropertyChanged(); } }

        public int Yesterday { get => _Yesterday; set { _Yesterday = value; OnPropertyChanged(); } }

        public int Streaks { get => _Streaks; set { _Streaks = value; OnPropertyChanged(); } }

        public int PercentGoal { get => _PercentGoal; set { _PercentGoal = value; OnPropertyChanged(); } }

        public PomodoroVM()
        {
            pomodoro = new Pomodoros();

            BtnPauseContent = "⬛";
            BackButtonEnable = false;

            SettingVisibility = Visibility.Visible;
            CountdownVisibility = Visibility.Hidden;

            Turn = true;
            BreakTimeCheckButtonEnable = true;
            TimesCheckButtonEnable = true;

            TasksList = new ObservableCollection<string>();

            string[] res = File.ReadAllLines(Clock.Properties.Resources.DailyProgress);
            Yesterday = Int32.Parse(res[0]);
            Streaks = Int32.Parse(res[1]);
            DailyGoal = Int32.Parse(res[2]);
            int day = Int32.Parse(res[3]);
            int month = Int32.Parse(res[4]);
            int year = Int32.Parse(res[5]);

            if(DateTime.Now.Day != day && DateTime.Now.Month != month && DateTime.Now.Year != year)
            {
                DailyGoal = 0;
            }

            DateTime d1 = DateTime.Now.AddDays(-1);

            if(d1.Day != day && d1.Month != month && d1.Year != year && DateTime.Now.Day != day && DateTime.Now.Month != month && DateTime.Now.Year != year)
            {
                Yesterday = 0;
                Streaks = 0;
            }

            PercentGoal = (int)(DailyGoal * 100 / 90 * 3.6);

            Completed = DailyGoal.ToString() + " minutes";

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
                if (pomodoro.FocusTimeIndex < pomodoro.FocusTimeList.Count - 1)
                {
                    pomodoro.FocusTimeIndex++;
                    FocusTimeDisplay = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex].ToString();
                }
            });
            FocusTimeDown = new RelayCommand((p) =>
            {
                if (pomodoro.FocusTimeIndex > 0)
                {
                    pomodoro.FocusTimeIndex--;
                    FocusTimeDisplay = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex].ToString();
                }
            });

            BreakTimeUp = new RelayCommand((p) =>
            {
                if (pomodoro.BreakTimeIndex < pomodoro.BreakTimeList.Count - 1)
                {
                    pomodoro.BreakTimeIndex++;
                    BreakTimeDisplay = pomodoro.BreakTimeList[pomodoro.BreakTimeIndex].ToString();
                }
            });
            BreakTimeDown = new RelayCommand((p) =>
            {
                if (pomodoro.BreakTimeIndex > 0)
                {
                    pomodoro.BreakTimeIndex--;
                    BreakTimeDisplay = pomodoro.BreakTimeList[pomodoro.BreakTimeIndex].ToString();
                }
            });

            TimesUp = new RelayCommand((p) =>
            {
                if (pomodoro.Times < 10)
                {
                    pomodoro.Times++;
                    NumberOfPomodoros = pomodoro.Times.ToString();
                }
            });
            TimesDown = new RelayCommand((p) =>
            {
                if (pomodoro.Times > 2)
                {
                    pomodoro.Times--;
                    NumberOfPomodoros = pomodoro.Times.ToString();
                }
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
            });
            CheckTimes = new RelayCommand((p) =>
            {
                if (IsTimes == true)
                {
                    TimesCheckButtonEnable = false;
                }
                else
                {
                    TimesCheckButtonEnable = true;
                }
            });

            StartFocus = new RelayCommand((p) =>
            {
                SettingVisibility = Visibility.Hidden;
                CountdownVisibility = Visibility.Visible;

                pomodoro.FocusTime = new PomodoroTime(pomodoro.FocusTimeList[pomodoro.FocusTimeIndex], 0);

                if (IsBreaks == false)
                    pomodoro.BreakTime = new PomodoroTime(pomodoro.BreakTimeList[pomodoro.BreakTimeIndex], 0);
                else
                    pomodoro.BreakTime = new PomodoroTime(0, 0);

                if (pomodoro.FocusTime.Minutes >= 10)
                {
                    CountdownDisplay = pomodoro.FocusTime.Minutes.ToString() + ":0" + pomodoro.FocusTime.Seconds.ToString();
                }
                else
                {
                    CountdownDisplay = '0' + pomodoro.FocusTime.Minutes.ToString() + ":0" + pomodoro.FocusTime.Seconds.ToString();
                }

                if (IsTimes == true) pomodoro.Times = 11;
                else pomodoro.Times--;
                FocusTimer.Start();
            });

            Pause = new RelayCommand((p) =>
            {
                if (Turn == true)
                {
                    if (BtnPauseContent == "⬛")
                    {
                        FocusTimer.Stop();
                        BtnPauseContent = "▶️";
                        BackButtonEnable = true;
                    }
                    else
                    {
                        FocusTimer.Start();
                        BtnPauseContent = "⬛";
                        BackButtonEnable = false;
                    }
                }
                else
                {
                    if (BtnPauseContent == "⬛")
                    {
                        BreakTimer.Stop();
                        BtnPauseContent = "▶️";
                        BackButtonEnable = true;
                    }
                    else
                    {
                        BreakTimer.Start();
                        BtnPauseContent = "⬛";
                        BackButtonEnable = false;
                    }
                }
            });
            Back = new RelayCommand((p) =>
            {
                if (Turn == true)
                {
                    FocusTimer.Stop();
                    SettingVisibility = Visibility.Visible;
                    CountdownVisibility = Visibility.Hidden;
                    BtnPauseContent = "⬛";
                    BackButtonEnable = false;
                    IsBreaks = false;
                    IsTimes = false;
                    BreakTimeCheckButtonEnable = true;
                    TimesCheckButtonEnable = true;

                    if(60 - pomodoro.FocusTime.Seconds == 60)
                        DailyGoal += pomodoro.FocusTime.SettingMinutes - pomodoro.FocusTime.Minutes;
                    else
                        DailyGoal += pomodoro.FocusTime.SettingMinutes - pomodoro.FocusTime.Minutes - 1;
                    Completed = DailyGoal.ToString() + " minutes";
                    PercentGoal = (int)(DailyGoal * 100 / 90 * 3.6);

                    string[] res = new string[6];
                    res[0] = Yesterday.ToString();
                    res[1] = Streaks.ToString();
                    res[2] = DailyGoal.ToString();
                    res[3] = day.ToString();
                }
                else
                {
                    BreakTimer.Stop();
                    SettingVisibility = Visibility.Visible;
                    CountdownVisibility = Visibility.Hidden;
                    BtnPauseContent = "⬛";
                    BackButtonEnable = false;
                    IsBreaks = false;
                    IsTimes = false;
                    Turn = true;
                    BreakTimeCheckButtonEnable = true;
                    TimesCheckButtonEnable = true;
                    Completed = DailyGoal.ToString() + " minutes";
                    PercentGoal = (int)(DailyGoal * 100 / 90 * 3.6);
                }
            });
            Skip = new RelayCommand((p) =>
            {
                if (Turn == true)
                {
                    FocusTimer.Stop();

                    if (60 - pomodoro.FocusTime.Seconds == 60)
                        DailyGoal += pomodoro.FocusTime.SettingMinutes - pomodoro.FocusTime.Minutes;
                    else
                        DailyGoal += pomodoro.FocusTime.SettingMinutes - pomodoro.FocusTime.Minutes - 1;

                    if (pomodoro.Times == 0)
                    {
                        SettingVisibility = Visibility.Visible;
                        CountdownVisibility = Visibility.Hidden;
                        BtnPauseContent = "⬛";
                        BackButtonEnable = false;
                        IsBreaks = false;
                        IsTimes = false;
                        BreakTimeCheckButtonEnable = true;
                        TimesCheckButtonEnable = true;
                        Completed = DailyGoal.ToString() + " minutes";
                        PercentGoal = (int)(DailyGoal * 100 / 90 * 3.6);
                    }
                    else
                    {
                        Turn = false;
                        pomodoro.FocusTime.Reset();
                        if (pomodoro.Times <= 10) pomodoro.Times--;
                        BtnPauseContent = "⬛";
                        BackButtonEnable = false;
                        BreakTimer.Start();
                    }
                }
                else
                {
                    BreakTimer.Stop();

                    Turn = true;
                    pomodoro.BreakTime.Reset();
                    BtnPauseContent = "⬛";
                    BackButtonEnable = false;   
                    FocusTimer.Start();
                }
            });

            
        }

        private void BreakTimer_Tick(object? sender, EventArgs e)
        {
            CountdownDisplay = string.Empty;
            if (pomodoro.BreakTime.Minutes == 0 && pomodoro.BreakTime.Seconds == 0)
            {
                BreakTimer.Stop();
                Turn = true;
                pomodoro.BreakTime.Reset();

                FocusTimer.Start();
            }
            else
            {
                pomodoro.BreakTime.ChangeTime();

                CountdownDisplay = pomodoro.BreakTime.TimetoString();
            }
        }

        private void FocusTimer_Tick(object? sender, EventArgs e)
        {
            CountdownDisplay = string.Empty;
            if (pomodoro.FocusTime.Minutes == 0 && pomodoro.FocusTime.Seconds == 0)
            {
                FocusTimer.Stop();
                DailyGoal += pomodoro.FocusTime.SettingMinutes;

                if (IsBreaks == true || pomodoro.Times == 0)
                {
                    SettingVisibility = Visibility.Visible;
                    CountdownVisibility = Visibility.Hidden;
                    IsBreaks = false;
                    if (IsTimes == true) IsTimes = false;
                    pomodoro.Times = 2;
                    Completed = DailyGoal.ToString() + " minutes";
                    PercentGoal = (int)(DailyGoal * 100 / 90 * 3.6);
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

        private int GetFocusTime()
        {
            int FT;
            if (int.TryParse(FocusTimeDisplay, out FT) == true)
            {
                FT = Int32.Parse(FocusTimeDisplay);
                return FT;
            }
            else
            {
                FT = pomodoro.FocusTimeList[pomodoro.FocusTimeIndex];
                return FT;
            }
        }

        

    }   

}
