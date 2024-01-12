﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Forms = System.Windows.Forms;

namespace Clock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly Forms.NotifyIcon notifyIcon;

        public App()
        {
            notifyIcon = new Forms.NotifyIcon();
        }

        

        void AddNotifyIcon()
        {
            notifyIcon.Visible = true;
            notifyIcon.Text = "Clock";
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            notifyIcon.ContextMenuStrip = new Forms.ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Exit Clock",null, ExitAppClicked);

            string pathIcon = GetPathForIconOfNotify();

            notifyIcon.Icon = new System.Drawing.Icon(GetPathForIconOfNotify());
        }

        void ExitAppClicked(object sender, EventArgs e)
        {
            Shutdown();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            AddNotifyIcon();

            base.OnStartup(e);
        }

        private void NotifyIcon_DoubleClick(object? sender, EventArgs e)
        {
            MainWindow.Show();
            if (MainWindow.WindowState == WindowState.Minimized) 
                MainWindow.WindowState = WindowState.Normal;
        }

        string GetPathForIconOfNotify()
        {
            string projectDirectory = AppContext.BaseDirectory;
            DirectoryInfo parentDirectory = Directory.GetParent(projectDirectory);
            parentDirectory = Directory.GetParent(parentDirectory.FullName);
            parentDirectory = Directory.GetParent(parentDirectory.FullName);
            parentDirectory = Directory.GetParent(parentDirectory.FullName);
            return parentDirectory.FullName + "/Images/notifyicon_icon.ico";
        }

        protected override void OnExit(ExitEventArgs e) 
        {
            notifyIcon.Dispose();
            base.OnExit(e);
        }
    }
}
