using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using Forms = System.Windows.Forms;

namespace Clock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        //private readonly Forms.NotifyIcon notifyIcon;

        public App()
        {
            Notif.notifyIcon = new Forms.NotifyIcon();
        }

        void AddNotifyIcon()
        {
            Notif.notifyIcon.Visible = true;
            Notif.notifyIcon.Text = "Clock";
            Notif.notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            Notif.notifyIcon.ContextMenuStrip = new Forms.ContextMenuStrip();
            Notif.notifyIcon.ContextMenuStrip.Items.Add("Open Clock", null, NotifyIcon_DoubleClick);
            Notif.notifyIcon.ContextMenuStrip.Items.Add("Exit Clock", null, ExitAppClicked);

            Notif.notifyIcon.Icon = Clock.Properties.Resources.notifyicon_icon;
        }


        private static Mutex _mutex = null;

        protected override void OnStartup(StartupEventArgs e)
        {

            const string appName = "Clock";
            bool createdNew;

            _mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                System.Windows.Application.Current.Shutdown();
            }

            AddNotifyIcon();
            base.OnStartup(e);
        }


        void ExitAppClicked(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void NotifyIcon_DoubleClick(object? sender, EventArgs e)
        {
            MainWindow.Show();
            //if (MainWindow.WindowState == WindowState.Minimized)
            //    MainWindow.WindowState = WindowState.Normal;
        }

        protected override void OnExit(ExitEventArgs e) 
        {
            Notif.notifyIcon.Dispose();
            base.OnExit(e);
        }
    }

    public static class Notif
    {
        public static Forms.NotifyIcon notifyIcon;
    }    
}
