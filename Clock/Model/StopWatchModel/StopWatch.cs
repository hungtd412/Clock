using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.StopWatchModel
{
    public class StopWatch
    {
        private readonly string _StartTime;          // giá trị mặc định 
        private string _TimeDisplay;            // chuỗi hiển thị thời gian
        private string _FlagDisplay;        // chuỗi hiển thị thời gian khi nhấn Flag
        private Flag _Fastest;
        private Flag _Slowest;
        private int _Laps;
        private Time _MainTime;             // lưu giá trị của thời gian
        private Time _FlagTime;             // lưu giá trị của thời gian khi nhấn Flag
        public string TimeDisplay { get => _TimeDisplay; set => _TimeDisplay = value; }
        public string StartTime { get => _StartTime; }
        public string FlagDisplay { get => _FlagDisplay; set => _FlagDisplay = value; }
        public int Laps { get => _Laps; set => _Laps = value; }
        internal Flag Fastest { get => _Fastest; set => _Fastest = value; }
        internal Flag Slowest { get => _Slowest; set => _Slowest = value; }
        internal Time MainTime { get => _MainTime; set => _MainTime = value; }
        internal Time FlagTime { get => _FlagTime; set => _FlagTime = value; }

        public StopWatch()
        {
            Fastest = new Flag(int.MaxValue);
            Slowest = new Flag(int.MinValue);
            _StartTime = "0:0:0.0";
            Laps = -1;
            MainTime = new Time();
            FlagTime = new Time();
        }

        

        // gán giá trị của chuỗi hiển thị thời gian
        private void SetTimeDisplay(string value)
        {
            this.TimeDisplay = value;
        }

        // gán giá trị của chuỗi hiển thị thời gian Flag
        private void SetFlagTimeDisplay(string value)
        {
            FlagDisplay = value;
        }

        // tăng giá trị thời gian hiện tại lên 10ms
        private static void UpdateTime(ref Time time)
        {
            time.Milliseconds++;
            if (time.Milliseconds == 9)
            {
                time.Milliseconds = 0;
                time.Seconds++;
            }
            if (time.Seconds == 60)
            {
                time.Seconds = 0;
                time.Minutes++;
            }
            if (time.Minutes == 60)
            {
                time.Minutes = 0;
                time.Hours++;
            }
        }

        // chuyển giá trị thời gian từ Time sang string
        private static string TimeToString(Time time)
        {
            return time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString() + "." + time.Milliseconds.ToString();
        }

        // trừ thời gian để tìm ra thời điểm nhấn Flag
        private static int SubtractTime(Time maintime, Time flagtime)
        {
            int res_maintime = maintime.Milliseconds * 100 + maintime.Seconds * 1000 + maintime.Minutes * 60 * 1000 + maintime.Hours * 60 * 60 * 1000;
            int res_flagtime = flagtime.Milliseconds * 100 + flagtime.Seconds * 1000 + flagtime.Minutes * 60 * 1000 + maintime.Hours * 60 * 60 * 1000;
            return res_maintime - res_flagtime;
        }

        // chuyển giá trị thời gian từ Miliseconds sang Time
        private static Time MiliToTime(int value)
        {
            Time time = new();

            time.Hours = (int)(value / 60 / 60 / 1000);
            value -= time.Hours * 60 * 60 * 1000;

            time.Minutes = (int)(value / 60 / 1000);
            value -= time.Minutes * 60 * 1000;

            time.Seconds = (int)(value / 1000);
            value -= time.Seconds * 1000;

            time.Milliseconds = (int)(value / 100);

            return time;
        }

        // xác định giá trị Fastest và Slowest khi nhấn Flag
        private void SetFlagIndex(int value, int index)
        {
            if (value > Slowest.Value)
            {
                Slowest.Value = value;
                Slowest.PreIndex = Slowest.Index;
                Slowest.Index = index - Laps - 1;
            }
            if (value < Fastest.Value)
            {
                Fastest.Value = value;
                Fastest.PreIndex = Fastest.Index;
                Fastest.Index = index - Laps - 1;
            }
        }

        // cập nhật chuỗi hiển thị giá trị thời gian của TimeDisplay
        public void UpdateTimeDisplay()
        {
            SetTimeDisplay(string.Empty);
            Time time = MainTime;
            UpdateTime(ref time);
            SetTimeDisplay(TimeToString(time));
        }

        // cập nhật chuỗi hiển thị giá trị thời gian của FlagTimeDisplay (index là số phần tử của listview dùng để hiển thị flagtime)
        public void UpdateFlagTimeDisplay(int index)
        {
            SetFlagTimeDisplay(string.Empty);

            int flagtime = SubtractTime(MainTime, FlagTime);

            SetFlagIndex(flagtime, index);

            SetFlagTimeDisplay(TimeToString(MiliToTime(flagtime)));

            FlagTime.Hours = MainTime.Hours;
            FlagTime.Minutes = MainTime.Minutes;
            FlagTime.Seconds = MainTime.Seconds;
            FlagTime.Milliseconds = MainTime.Milliseconds;
        }
    }
}
