using Clock.Ultilities;
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

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            WindowStyleControl.Exit();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            WindowStyleControl.DoMaximize(this, btn);
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowStyleControl.Minimize(this);
        }

        private void Drag_Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
