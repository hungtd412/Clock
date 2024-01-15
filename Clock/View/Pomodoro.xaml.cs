﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Forms = System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Clock.View
{
    /// <summary>
    /// Interaction logic for Pomodoro.xaml
    /// </summary>
    public partial class Pomodoro : UserControl
    {
        private Forms.NotifyIcon notifyIcon;

        List<int> time = new List<int>() { 10, 15, 20, 25, 30, 35, 40, 45, 50, 60, 90, 120, 150, 180, 210, 240 };
        List<int> break_time = new List<int>() { 1, 2, 3, 4, 5, 10, 15, 20, 25, 30 };


        static int count = 3;
        static int BreakTime_count = 4;
        private DispatcherTimer _timer;
        private DispatcherTimer breakTime;
        private string Display;
        private bool f_or_b = true;
        private int fm, fs, bm, bs;
        private int dfm, dfs, dbm, dbs;
        private bool? have_breaks;
        private int NumberOfPomodoros;
        private bool check_task_empty = false;
        private int Dailygoal = 0;

        public Pomodoro()
        {
            InitializeComponent();
            txblFocusTime.Text = time[3].ToString();
            lbBreak_time.Content = break_time[4].ToString();

            _timer = new DispatcherTimer();

            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;

            breakTime = new DispatcherTimer();
            breakTime.Interval = TimeSpan.FromSeconds(1);
            breakTime.Tick += BreakTime_Tick;

            notifyIcon = new Forms.NotifyIcon();
            //notifyIcon.Icon = Clock.Properties.Resources.notifyicon_icon;
            notifyIcon.Visible = true;
        }

        private void BreakTime_Tick(object sender, EventArgs e)
        {
            Display = string.Empty;
            if (bs == 0 && bm == 0)
            {
                breakTime.Stop();
                f_or_b = true;
                bm = dbm;
                bs = dbs;

                if (have_breaks == false)
                {
                    notifyIcon.ShowBalloonTip(500, "Ding Dong!", "Break time has left.", Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    _timer.Start();
                }
                else
                {
                    notifyIcon.ShowBalloonTip(500, "Ding Dong!", "Focus time has left.", Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    _timer.Start();
                }
            }
            else
            {
                if (bs == 0)
                {
                    bm -= 1;
                    bs = 60;
                }

                bs--;

                if (bm < 10) Display += '0' + bm.ToString() + ':';
                else Display += bm.ToString() + ':';

                if (bs < 10) Display += '0' + bs.ToString();
                else Display += bs.ToString();

                txblCountdown.Text = Display;
            }
        }

        private void Init()
        {
            int focustime = Get_Focus_Time();
            int breaktime = Get_Break_Time();

            dfm = focustime;
            fm = focustime;
            fs = 0;
            dfs = 0;
            dbm = breaktime;
            bm = breaktime;
            bs = 0;
            dbs = 0;
            if (dfm >= 10)
            {
                txblCountdown.Text = fm.ToString() + ":0" + fs.ToString();
            }
            else
                txblCountdown.Text = '0' + fm.ToString() + ":0" + fs.ToString();
            have_breaks = Cb_Have_Breaks.IsChecked;

            if (Cb_Until_Stop.IsChecked == true) NumberOfPomodoros = 11;
            else NumberOfPomodoros = Int32.Parse((string)txbTimes.Content) - 1;

        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            Display = string.Empty;
            if (fs == 0 && fm == 0)
            {
                _timer.Stop();
                if (Dailygoal + dfm < 90) Dailygoal += dfm;
                else Dailygoal = 90;

                if (have_breaks == true || NumberOfPomodoros == 0)
                {
                    notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Well done! You have finished your focus session.",Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    Cv_Break.Visibility = Visibility.Visible;
                    Cv_Focus.Visibility = Visibility.Visible;
                    Cv_Countdown.Visibility = Visibility.Hidden;
                    Cb_Have_Breaks.IsChecked = false;
                    BreakTime_Down_Button.IsEnabled = true;
                    BreakTime_Up_Button.IsEnabled = true;
                    Times_Down_Button.IsEnabled = true;
                    Times_Up_Button.IsEnabled = true;
                    Complete.Text = Dailygoal.ToString() + " minutes"; 
                    Arc1.EndAngle = (int)(Dailygoal * 100 / 90 * 3.6);

                }
                else
                {
                    notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Good job! Take a rest before continue focusing.", Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    f_or_b = false;
                    fm = dfm;
                    fs = dfs;
                    if (NumberOfPomodoros <= 10) NumberOfPomodoros--;
                    breakTime.Start();
                }
            }
            else
            {
                if (fs == 0)
                {
                    fm -= 1;
                    fs = 60;
                }

                fs--;

                if (fm < 10) Display += '0' + fm.ToString() + ':';
                else Display += fm.ToString() + ':';

                if (fs < 10) Display += '0' + fs.ToString();
                else Display += fs.ToString();

                txblCountdown.Text = Display;
            }
        }

        void Set_index_textchanged()
        {
            int focus_time = Get_Focus_Time();
            for (int i = 1; i < time.Count - 1; i++)
            {
                if (time[i] == focus_time)
                {
                    count = i;
                    break;
                }
                if (time[i] > focus_time)
                {
                    count = i - 1;
                    break;
                }
            }
        }

        private int Get_Focus_Time()
        {
            int focus_time;
            if (int.TryParse(txblFocusTime.Text, out focus_time) == true)
            {
                focus_time = int.Parse(txblFocusTime.Text);
                return focus_time;
            }
            else
            {
                focus_time = time[count];
                return focus_time;
            }

        }

        private int Get_Break_Time()
        {
            if (Cb_Have_Breaks.IsChecked == false)
            {
                int breaktime = Int32.Parse((string)lbBreak_time.Content);
                return breaktime;
            }
            else return 0;
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                count--;
                txblFocusTime.Text = time[count].ToString();
            }
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            if (count < time.Count - 1)
            {
                count++;
                txblFocusTime.Text = time[count].ToString();
            }
        }

        private void txblFocusTime_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txblFocusTime.Text != string.Empty)
            {
                if (Get_Focus_Time() < time[0])
                {
                    txblFocusTime.Text = time[0].ToString();
                    count = 0;
                }
                else if (Get_Focus_Time() > time[time.Count - 1])
                {
                    txblFocusTime.Text = time[time.Count - 1].ToString();
                    count = time.Count - 1;
                }
                else if (Get_Focus_Time() == time[count])
                {
                    txblFocusTime.Text = Get_Focus_Time().ToString();
                }
                else
                {
                    Set_index_textchanged();
                }
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main_Grid.Focus();
        }

        private void BreakTime_Up_Click(object sender, RoutedEventArgs e)
        {
            if (BreakTime_count < break_time.Count - 1)
            {
                BreakTime_count++;
                lbBreak_time.Content = break_time[BreakTime_count].ToString();
            }
        }

        private void BreakTime_Down_Click(object sender, RoutedEventArgs e)
        {
            if (BreakTime_count > 0)
            {
                BreakTime_count--;
                lbBreak_time.Content = break_time[BreakTime_count].ToString();
            }
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            if (f_or_b == true)
            {
                if ((string)Pause_Button.Content == "⬛")
                {
                    _timer.Stop();
                    Pause_Button.Content = "▶️";
                    Back_Button.IsEnabled = true;
                }
                else
                {
                    _timer.Start();
                    Pause_Button.Content = "⬛";
                    Back_Button.IsEnabled = false;
                }
            }
            else
            {
                if ((string)Pause_Button.Content == "⬛")
                {
                    breakTime.Stop();
                    Pause_Button.Content = "▶️";
                    Back_Button.IsEnabled = true;
                }
                else
                {
                    breakTime.Start();
                    Pause_Button.Content = "⬛";
                    Back_Button.IsEnabled = false;
                }
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            if (f_or_b == true)
            {
                notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Well done! You have finished your focus session.", Forms.ToolTipIcon.Info);
                SystemSounds.Asterisk.Play();
                _timer.Stop();
                Cv_Break.Visibility = Visibility.Visible;
                Cv_Focus.Visibility = Visibility.Visible;
                Cv_Countdown.Visibility = Visibility.Hidden;
                Pause_Button.Content = "⬛";
                Back_Button.IsEnabled = false;
                Cb_Have_Breaks.IsChecked = false;
                Cb_Until_Stop.IsChecked = false;
                BreakTime_Down_Button.IsEnabled = true;
                BreakTime_Up_Button.IsEnabled = true;
                Times_Down_Button.IsEnabled = true;
                Times_Up_Button.IsEnabled = true;

                if(60 - fs == 60)
                {
                    if (Dailygoal + dfm - fm < 90) Dailygoal += dfm - fm;
                    else Dailygoal = 90;
                }
                else
                {
                    if (Dailygoal + dfm - fm - 1 < 90) Dailygoal += dfm - fm - 1;
                    else Dailygoal = 90;
                }
                Complete.Text = Dailygoal.ToString() + " minutes";
                Arc1.EndAngle = (int)(Dailygoal * 100 / 90 * 3.6);
            }
            if (f_or_b == false)
            {
                notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Well done! You have finished your focus session.", Forms.ToolTipIcon.Info);
                SystemSounds.Asterisk.Play();
                breakTime.Stop();
                Cv_Break.Visibility = Visibility.Visible;
                Cv_Focus.Visibility = Visibility.Visible;
                Cv_Countdown.Visibility = Visibility.Hidden;
                f_or_b = true;
                Pause_Button.Content = "⬛";
                Back_Button.IsEnabled = false;
                Cb_Have_Breaks.IsChecked = false;
                Cb_Until_Stop.IsChecked = false;
                BreakTime_Down_Button.IsEnabled = true;
                BreakTime_Up_Button.IsEnabled = true;
                Times_Down_Button.IsEnabled = true;
                Times_Up_Button.IsEnabled = true;

                if (60 - fs == 60)
                {
                    if (Dailygoal + dfm - fm < 90) Dailygoal += dfm - fm;
                    else Dailygoal = 90;
                }
                else
                {
                    if (Dailygoal + dfm - fm - 1 < 90) Dailygoal += dfm - fm - 1;
                    else Dailygoal = 90;
                }
                Complete.Text = Dailygoal.ToString() + " minutes";
                Arc1.EndAngle = (int)(Dailygoal * 100 / 90 * 3.6);
            }
        }

        private void Start_Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Lsv_tasks.Visibility = Visibility.Visible;
            Stay_on_track.Visibility = Visibility.Hidden;
            Add_Tasks_and.Visibility = Visibility.Hidden;
            Start_Button_Copy.Visibility = Visibility.Hidden;

            TextBox newtb = new TextBox();

            Lsv_tasks.Items.Add(newtb);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lsv_tasks.Visibility = Visibility.Visible;
            Stay_on_track.Visibility = Visibility.Hidden;
            Add_Tasks_and.Visibility = Visibility.Hidden;
            Start_Button_Copy.Visibility = Visibility.Hidden;

            TextBox newtb = new TextBox();

            Lsv_tasks.Items.Add(newtb);
        }

        private void NewTB_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            check_task_empty = false;
            if (e.Key == Key.Enter)
            {

                if (tb.Text == string.Empty)
                {
                    //Lsv_tasks.Items.RemoveAt(Lsv_tasks.Items.Count-1);

                }
                if (Lsv_tasks.Items.Count == 0)
                {
                    Lsv_tasks.Visibility = Visibility.Hidden;
                    Stay_on_track.Visibility = Visibility.Visible;
                    Add_Tasks_and.Visibility = Visibility.Visible;
                    Start_Button_Copy.Visibility = Visibility.Visible;
                }
                Lsv_tasks.SelectedItem = null;
                Main_Grid.Focus();
            }

        }

        private void NewTB_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text == string.Empty && check_task_empty == true)
            {
                //Lsv_tasks.Items.RemoveAt(Lsv_tasks.Items.Count - 1);
                if (Lsv_tasks.Items.Count == 0)
                {
                    Lsv_tasks.Visibility = Visibility.Hidden;
                    Stay_on_track.Visibility = Visibility.Visible;
                    Add_Tasks_and.Visibility = Visibility.Visible;
                    Start_Button_Copy.Visibility = Visibility.Visible;
                }
            }
            Lsv_tasks.SelectedItem = null;
            check_task_empty = true;
        }

        private void NewTB_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                TextBox textBox = (TextBox)sender;

                ContextMenu contextMenu = new ContextMenu();
                MenuItem deleteItem = new MenuItem()
                {
                    Header = "Delete this task",
                    Background = Brushes.LightSlateGray,
                };
                MenuItem strikethroughItem = new MenuItem()
                {
                    Header = "Complete this task",
                    Background = Brushes.LightSlateGray,
                };
                deleteItem.Click += (s, args) => DeleteItem(textBox.DataContext);
                strikethroughItem.Click += (s, args) => ToggleStrikethrough(textBox);

                contextMenu.Items.Add(deleteItem);
                contextMenu.Items.Add(strikethroughItem);

                textBox.ContextMenu = contextMenu;
            }
        }

        private void DeleteItem(object item)
        {
            Lsv_tasks.Items.Remove(item);
        }

        private void ToggleStrikethrough(TextBox textBox)
        {
            if (textBox.TextDecorations.Count == 0)
            {
                textBox.TextDecorations.Add(TextDecorations.Strikethrough);
            }
            else
            {
                textBox.TextDecorations.Clear();
            }
        }
        private void Skip_Button_Click(object sender, RoutedEventArgs e)
        {
            if (f_or_b == true)
            {
                _timer.Stop();

                if (60 - fs == 60)
                {
                    if (Dailygoal + dfm - fm < 90) Dailygoal += dfm - fm;
                    else Dailygoal = 90;
                }
                else
                {
                    if (Dailygoal + dfm - fm - 1 < 90) Dailygoal += dfm - fm - 1;
                    else Dailygoal = 90;
                }

                if (NumberOfPomodoros == 0)
                {
                    notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Well done! You have finished your focus session.", Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    Cv_Break.Visibility = Visibility.Visible;
                    Cv_Focus.Visibility = Visibility.Visible;
                    Cv_Countdown.Visibility = Visibility.Hidden;
                    Pause_Button.Content = "⬛";
                    Back_Button.IsEnabled = false;
                    BreakTime_Down_Button.IsEnabled = true;
                    BreakTime_Up_Button.IsEnabled = true;
                    Times_Down_Button.IsEnabled = true;
                    Times_Up_Button.IsEnabled = true;

                    Complete.Text = Dailygoal.ToString() + " minutes";
                    Arc1.EndAngle = (int)(Dailygoal * 100 / 90 * 3.6);

                }
                else 
                {
                    notifyIcon.ShowBalloonTip(500, "Congratulastions!", "Good job! Take a rest before continue focusing.", Forms.ToolTipIcon.Info);
                    SystemSounds.Asterisk.Play();
                    f_or_b = false;
                    fm = dfm;
                    fs = dfs;
                    if (NumberOfPomodoros <= 10) NumberOfPomodoros--;
                    Pause_Button.Content = "⬛";
                    Back_Button.IsEnabled = false;
                    breakTime.Start();
                }
            }
            else
            {
                breakTime.Stop();
                f_or_b = true;
                bm = dbm;
                bs = dbs;

                notifyIcon.ShowBalloonTip(500, "Ding Dong!", "Break time has left.", Forms.ToolTipIcon.Info);
                SystemSounds.Asterisk.Play();

                Pause_Button.Content = "⬛";
                Back_Button.IsEnabled = false;
                _timer.Start();

            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (Cb_Have_Breaks.IsChecked == true)
            {
                BreakTime_Up_Button.IsEnabled = false;
                BreakTime_Down_Button.IsEnabled = false;
            }
            else
            {
                BreakTime_Up_Button.IsEnabled = true;
                BreakTime_Down_Button.IsEnabled = true;
            }
        }

        private void Times_Down_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse((string)txbTimes.Content) > 2)
            {
                txbTimes.Content = (Int32.Parse((string)txbTimes.Content) - 1).ToString();
            }
        }

        private void Times_Up_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse((string)txbTimes.Content) < 10)
            {
                txbTimes.Content = (Int32.Parse((string)txbTimes.Content) + 1).ToString();
            }
        }

        private void Cb_Until_Stop_Click(object sender, RoutedEventArgs e)
        {
            if (Cb_Until_Stop.IsChecked == true)
            {
                Times_Down_Button.IsEnabled = false;
                Times_Up_Button.IsEnabled = false;
            }
            else
            {
                Times_Down_Button.IsEnabled = true;
                Times_Up_Button.IsEnabled = true;
            }
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Cv_Break.Visibility = Visibility.Hidden;
            Cv_Focus.Visibility = Visibility.Hidden;
            Cv_Countdown.Visibility = Visibility.Visible;
            Init();
            _timer.Start();
        }
    }
}
