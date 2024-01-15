using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Model.PomodoroModel
{
    public class Pomodoros
    {
        private ObservableCollection<int> _FocusTimeList;
        private ObservableCollection<int> _BreakTimeList;
        private int _FocusTimeIndex;
        private int _BreakTimeIndex;
        private int _Times;
        private PomodoroTime _FocusTime;
        private PomodoroTime _BreakTime;

        public ObservableCollection<int> FocusTimeList { get => _FocusTimeList; set => _FocusTimeList = value; }
        public ObservableCollection<int> BreakTimeList { get => _BreakTimeList; set => _BreakTimeList = value; }
        public int FocusTimeIndex { get => _FocusTimeIndex; set => _FocusTimeIndex = value; }
        public int BreakTimeIndex { get => _BreakTimeIndex; set => _BreakTimeIndex = value; }
        public int Times { get => _Times; set => _Times = value; }
        internal PomodoroTime FocusTime { get => _FocusTime; set => _FocusTime = value; }
        internal PomodoroTime BreakTime { get => _BreakTime; set => _BreakTime = value; }

        public Pomodoros()
        {
            FocusTimeList = new ObservableCollection<int>() { 1, 10, 15, 20, 25, 30, 35, 40, 45, 50, 60, 90, 120, 150, 180, 210, 240 };
            BreakTimeList = new ObservableCollection<int>() { 1, 2, 3, 4, 5, 10, 15, 20, 25, 30 };
            FocusTimeIndex = 3;
            BreakTimeIndex = 4;
            Times = 2;
            FocusTime = new();
            BreakTime = new();
        }

        public void SetFocusTimeIndex(int value)
        {
            for(int i = 1; i < FocusTimeList.Count - 1; i++)
            {
                if (FocusTimeList[i] == value)
                {
                    FocusTimeIndex = i; 
                    break;
                }
                if (FocusTimeList[i] > value)
                {
                    FocusTimeIndex = i - 1;
                    break;
                }
            }
        }
    }
}
