﻿#pragma checksum "..\..\..\..\View\Pomodoro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343C3B68D669C61961AAA8194B8F9249A2E827E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clock.View;
using Clock.ViewModel;
using Microsoft.Expression.Controls;
using Microsoft.Expression.Media;
using Microsoft.Expression.Shapes;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Clock.View {
    
    
    /// <summary>
    /// Pomodoro
    /// </summary>
    public partial class Pomodoro : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 15 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main_Grid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Cv_Focus;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txblFocusTime;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start_Button;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Cv_Break;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cb_Have_Breaks;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BreakTime_Down_Button;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BreakTime_Up_Button;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbBreak_time;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Times_Down_Button;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Times_Up_Button;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txbTimes;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cb_Until_Stop;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Cv_Tasks;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Stay_on_track;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Add_Tasks_and;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start_Button_Copy;
        
        #line default
        #line hidden
        
        
        #line 294 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Lsv_tasks;
        
        #line default
        #line hidden
        
        
        #line 325 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Cv_Daily;
        
        #line default
        #line hidden
        
        
        #line 337 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Expression.Shapes.Arc Arc1;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Complete;
        
        #line default
        #line hidden
        
        
        #line 375 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas Cv_Countdown;
        
        #line default
        #line hidden
        
        
        #line 392 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblCountdown;
        
        #line default
        #line hidden
        
        
        #line 399 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pause_Button;
        
        #line default
        #line hidden
        
        
        #line 408 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_Button;
        
        #line default
        #line hidden
        
        
        #line 418 "..\..\..\..\View\Pomodoro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Skip_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clock;component/view/pomodoro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Pomodoro.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 13 "..\..\..\..\View\Pomodoro.xaml"
            ((Clock.View.Pomodoro)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Main_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Cv_Focus = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            
            #line 67 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Down_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 77 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Up_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txblFocusTime = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\..\View\Pomodoro.xaml"
            this.txblFocusTime.LostFocus += new System.Windows.RoutedEventHandler(this.txblFocusTime_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Start_Button = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\View\Pomodoro.xaml"
            this.Start_Button.Click += new System.Windows.RoutedEventHandler(this.Start_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Cv_Break = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.Cb_Have_Breaks = ((System.Windows.Controls.CheckBox)(target));
            
            #line 130 "..\..\..\..\View\Pomodoro.xaml"
            this.Cb_Have_Breaks.Click += new System.Windows.RoutedEventHandler(this.CheckBox_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BreakTime_Down_Button = ((System.Windows.Controls.Button)(target));
            
            #line 154 "..\..\..\..\View\Pomodoro.xaml"
            this.BreakTime_Down_Button.Click += new System.Windows.RoutedEventHandler(this.BreakTime_Down_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BreakTime_Up_Button = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\..\..\View\Pomodoro.xaml"
            this.BreakTime_Up_Button.Click += new System.Windows.RoutedEventHandler(this.BreakTime_Up_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lbBreak_time = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.Times_Down_Button = ((System.Windows.Controls.Button)(target));
            
            #line 211 "..\..\..\..\View\Pomodoro.xaml"
            this.Times_Down_Button.Click += new System.Windows.RoutedEventHandler(this.Times_Down_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Times_Up_Button = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\..\View\Pomodoro.xaml"
            this.Times_Up_Button.Click += new System.Windows.RoutedEventHandler(this.Times_Up_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.txbTimes = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.Cb_Until_Stop = ((System.Windows.Controls.CheckBox)(target));
            
            #line 243 "..\..\..\..\View\Pomodoro.xaml"
            this.Cb_Until_Stop.Click += new System.Windows.RoutedEventHandler(this.Cb_Until_Stop_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Cv_Tasks = ((System.Windows.Controls.Canvas)(target));
            return;
            case 18:
            
            #line 261 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.Stay_on_track = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.Add_Tasks_and = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 21:
            this.Start_Button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 293 "..\..\..\..\View\Pomodoro.xaml"
            this.Start_Button_Copy.Click += new System.Windows.RoutedEventHandler(this.Start_Button_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.Lsv_tasks = ((System.Windows.Controls.ListView)(target));
            return;
            case 24:
            this.Cv_Daily = ((System.Windows.Controls.Canvas)(target));
            return;
            case 25:
            this.Arc1 = ((Microsoft.Expression.Shapes.Arc)(target));
            return;
            case 26:
            this.Complete = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 27:
            this.Cv_Countdown = ((System.Windows.Controls.Canvas)(target));
            return;
            case 28:
            this.txblCountdown = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 29:
            this.Pause_Button = ((System.Windows.Controls.Button)(target));
            
            #line 406 "..\..\..\..\View\Pomodoro.xaml"
            this.Pause_Button.Click += new System.Windows.RoutedEventHandler(this.Pause_Button_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.Back_Button = ((System.Windows.Controls.Button)(target));
            
            #line 416 "..\..\..\..\View\Pomodoro.xaml"
            this.Back_Button.Click += new System.Windows.RoutedEventHandler(this.Back_Button_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            this.Skip_Button = ((System.Windows.Controls.Button)(target));
            
            #line 425 "..\..\..\..\View\Pomodoro.xaml"
            this.Skip_Button.Click += new System.Windows.RoutedEventHandler(this.Skip_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 23:
            
            #line 316 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.NewTB_KeyDown);
            
            #line default
            #line hidden
            
            #line 317 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.NewTB_LostFocus);
            
            #line default
            #line hidden
            
            #line 318 "..\..\..\..\View\Pomodoro.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.NewTB_PreviewMouseRightButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

