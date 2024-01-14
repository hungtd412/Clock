using Clock.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.PomodoroModel
{
    public class PomodoroTime
    {
        private int _Minutes;
        private int _Seconds;
        private int _SettingMinutes;
        private int _SettingSeconds;

        public int Minutes { get => _Minutes; set => _Minutes = value; }
        public int Seconds { get => _Seconds; set => _Seconds = value; }
        private int SettingMinutes { get => _SettingMinutes; set => _SettingMinutes = value; }
        private int SettingSeconds { get => _SettingSeconds; set => _SettingSeconds = value; }

        public PomodoroTime()
        {
            Minutes = 0;
            Seconds = 0;
            SettingMinutes = 0;
            SettingSeconds = 0;
        }

        public PomodoroTime(int minute, int second)
        {
            Minutes = minute;
            Seconds = second;
            SettingMinutes = minute;
            SettingSeconds = second;
        }

        public void Reset()
        {
            Minutes = SettingMinutes;
            Seconds = SettingSeconds;
        }

        public void Clear()
        {
            Minutes = 0;
            Seconds = 0;
            SettingMinutes = 0;
            SettingSeconds = 0;
        }

        public void ChangeTime()
        {
            if (Seconds == 0)
            {
                Minutes--;
                Seconds = 60;    
            }

            Seconds--;
        }

        public string TimetoString()
        {
            string res = string.Empty;

            if (Minutes < 10) res += '0' + Minutes.ToString() + ':';
            else res += Minutes.ToString() + ':';

            if (Seconds < 10) res += '0' + Seconds.ToString();
            else res += Seconds.ToString();

            return res;
        }
    }
}
