using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clock.View
{
    /// <summary>
    /// Interaction logic for EditDailyGoalView.xaml
    /// </summary>
    public partial class EditDailyGoalView : UserControl
    {
        public EditDailyGoalView()
        {
            InitializeComponent();
            for (int i = 0; i <= 59; i++)
            {
                pickMinute.Items.Add(i.ToString("D2"));
            }

            for (int i = 1; i <= 12; i++)
            {
                pickHour.Items.Add(i.ToString("D2"));
            }

            pickAMPM.Items.Add("AM");
            pickAMPM.Items.Add("PM");
        }

        private void PickTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (pickTimeCbox.SelectedIndex == 0)
            //{
            //    pickTimeCbox.Text = string.Empty;
            //}
        }
    }
}
