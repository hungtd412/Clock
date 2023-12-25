using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Threading;
using Clock.Model.StopWatchModel;
using Clock.Utilities;

namespace Clock.ViewModel
{
    public class StopwatchVM : Utilities.ViewModelBase
    {
        private StopWatch stopwatch;
        private DispatcherTimer timer;

        
        private string _TimeDisplay;
        private string _FlagDisplay;
        private string _BtnStartContent;
        private Visibility _visibility;
        private ObservableCollection<string> _LapsList;
        private ObservableCollection<string> _SpeedList;
        private ObservableCollection<string> _TimeList;
        private ObservableCollection<string> _TotalList; 

        public ICommand StartCommand { get; set; }
        public ICommand LapsCommand { get; set; }
        public ICommand ClearCommand { get; set; }

        public string TimeDisplay { get => _TimeDisplay; set { _TimeDisplay = value; OnPropertyChanged(); } }
        public string FlagDisplay { get => _FlagDisplay; set { _FlagDisplay = value; OnPropertyChanged(); } }
        public string BtnStartContent { get => _BtnStartContent; set { _BtnStartContent = value; OnPropertyChanged(); } }
        public Visibility visibility { get => _visibility; set { _visibility = value; OnPropertyChanged(); } }
        public ObservableCollection<string> LapsList { get => _LapsList; set { _LapsList = value; OnPropertyChanged(); } }
        public ObservableCollection<string> SpeedList { get => _SpeedList; set { _SpeedList = value; OnPropertyChanged(); } }
        public ObservableCollection<string> TimeList { get => _TimeList; set { _TimeList = value; OnPropertyChanged(); } }
        public ObservableCollection<string> TotalList { get => _TotalList; set { _TotalList = value; OnPropertyChanged(); } }

        

        public StopwatchVM() 
        {
            stopwatch = new();
            TimeDisplay = stopwatch.StartTime;

            LapsList = new ObservableCollection<string>();
            SpeedList = new ObservableCollection<string>();
            TimeList = new ObservableCollection<string>();
            TotalList = new ObservableCollection<string>();

            BtnStartContent = "▶️";
            visibility = Visibility.Hidden;
       
            timer = new DispatcherTimer();
            timer.IsEnabled = false;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += timer_Tick;
            
            StartCommand = new RelayCommand((p) => 
            {
                if (timer.IsEnabled.ToString() == "False")
                {
                    BtnStartContent = "⬛";
                    timer.Start();                   
                }
                else
                {
                    BtnStartContent = "▶️";
                    timer.Stop();                   
                }
            }, (p) => { return true; });

            LapsCommand = new RelayCommand((p) =>
            {
                visibility = Visibility.Visible;
                stopwatch.Laps++;
                LapsList.Insert(0,(stopwatch.Laps+1).ToString());
                SpeedList.Insert(0, string.Empty);

                if(stopwatch.Laps >= 1)
                {
                    stopwatch.Fastest.Index++;
                    stopwatch.Fastest.PreIndex++;
                    stopwatch.Slowest.Index++;
                    stopwatch.Slowest.PreIndex++;
                }

                stopwatch.UpdateFlagTimeDisplay(SpeedList.Count);

                TimeList.Insert(0, stopwatch.FlagDisplay);
                TotalList.Insert(0, TimeDisplay);

                if(stopwatch.Laps >= 1)
                {
                    if(stopwatch.Slowest.PreIndex == stopwatch.Fastest.Index)
                    {
                        SpeedList.RemoveAt(stopwatch.Fastest.PreIndex);
                        SpeedList.Insert(stopwatch.Fastest.PreIndex, string.Empty);
                        SpeedList.RemoveAt(stopwatch.Fastest.Index);
                        SpeedList.Insert(stopwatch.Fastest.Index, "Fastest");

                        SpeedList.RemoveAt(stopwatch.Slowest.Index);
                        SpeedList.Insert(stopwatch.Slowest.Index, "Slowest");
                    }
                    else
                    {
                        SpeedList.RemoveAt(stopwatch.Fastest.PreIndex);
                        SpeedList.Insert(stopwatch.Fastest.PreIndex, string.Empty);
                        SpeedList.RemoveAt(stopwatch.Fastest.Index);
                        SpeedList.Insert(stopwatch.Fastest.Index, "Fastest");

                        SpeedList.RemoveAt(stopwatch.Slowest.PreIndex);
                        SpeedList.Insert(stopwatch.Slowest.PreIndex, string.Empty);
                        SpeedList.RemoveAt(stopwatch.Slowest.Index);
                        SpeedList.Insert(stopwatch.Slowest.Index, "Slowest");
                    }
                }

            }, (p) => 
            {
                if (timer.IsEnabled.ToString() == "False")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            });

            ClearCommand = new RelayCommand((p) => 
            {
                timer.Stop();
                visibility = Visibility.Hidden;
                TimeDisplay = stopwatch.StartTime;
                stopwatch.MainTime.Reset();
                stopwatch.FlagTime.Reset();
                stopwatch.Laps = -1;
                stopwatch.Fastest = new Flag(int.MaxValue);
                stopwatch.Slowest = new Flag(int.MinValue);
                LapsList.Clear();
                SpeedList.Clear();
                TimeList.Clear();
                TotalList.Clear();
                BtnStartContent = "▶️";


            }, (p) => { if (TimeDisplay == stopwatch.StartTime) return false; return true; });
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            stopwatch.UpdateTimeDisplay();
            TimeDisplay = stopwatch.TimeDisplay;
        }
    }
}
