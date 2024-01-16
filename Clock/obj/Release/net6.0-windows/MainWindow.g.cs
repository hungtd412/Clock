﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F2DDF81190EC75F64002A287B3168BE55BD3556"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Clock;
using Clock.Utilities;
using Clock.ViewModel;
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


namespace Clock {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainControl;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton Tg_Btn;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard HideStackPanel;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard ShowStackPanel;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Maximize;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Minimize;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Pages;
        
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
            System.Uri resourceLocater = new System.Uri("/Clock;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 18 "..\..\..\MainWindow.xaml"
            ((Clock.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\MainWindow.xaml"
            ((Clock.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainControl = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 48 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Drag_Move);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 107 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Drag_Move);
            
            #line default
            #line hidden
            
            #line 108 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Canvas)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Grid_MouseMove);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Tg_Btn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 6:
            this.HideStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 7:
            this.ShowStackPanel = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 8:
            this.btn_Close = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\MainWindow.xaml"
            this.btn_Close.Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_Maximize = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\..\MainWindow.xaml"
            this.btn_Maximize.Click += new System.Windows.RoutedEventHandler(this.Maximize_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\..\MainWindow.xaml"
            this.btn_Minimize.Click += new System.Windows.RoutedEventHandler(this.Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Pages = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

