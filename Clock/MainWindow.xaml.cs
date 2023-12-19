﻿using Clock.Utilities;
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
using Clock.Commands;
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

        private Point startPoint;

        private void Drag_Move(object sender, MouseButtonEventArgs e)
        {
            // Record the starting point when the mouse button is pressed
            startPoint = e.GetPosition(this);
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Calculate the distance moved from the starting point
                Point currentPoint = e.GetPosition(this);
                Vector diff = startPoint - currentPoint;

                // If the mouse has moved a certain distance, initiate the drag
                if (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
                {
                    isMax = false;
                    // Perform drag logic here
                    if (!isMax)
                        this.BorderThickness = new Thickness(0.7);
                    else
                        this.BorderThickness = new Thickness(0);
                    this.btn_Maximize.Content = "1";
                    DragMove();
                }
            }
        }

        bool isMax = false;  //trạng thái hiện tại của nút maximize, minimize.
        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            isMax = !isMax;
            if (isMax) // nếu đang full màn hình
                this.BorderThickness = new Thickness(0);
            else
                this.BorderThickness = new Thickness(0.7);
            Button btn = (Button)sender;
            WindowStyleControl.DoMaximize(this, btn);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (this.Width <= 850)
            {
                Tg_Btn.IsChecked = true;
                Tg_Btn.Visibility = Visibility.Visible;
            }
            else
            {
                Tg_Btn.IsChecked = false;
                Tg_Btn.Visibility = Visibility.Collapsed;
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowStyleControl.Minimize(this);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            WindowStyleControl.Exit();
        }
    }
}
