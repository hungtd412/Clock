﻿#pragma checksum "..\..\..\..\View\Stopwatch.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F52C61F157CA641292A57151C7BAE1F4DD0CBB2B"
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
    /// Stopwatch
    /// </summary>
    public partial class Stopwatch : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TimeDisplay;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock hrDisplay;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock minDisplay;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock secDisplay;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblLaps;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblTime;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txblTotal;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Laps;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Speed;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Time;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\..\View\Stopwatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Total;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clock;component/view/stopwatch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Stopwatch.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TimeDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.hrDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.minDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.secDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txblLaps = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txblTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txblTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Laps = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.Speed = ((System.Windows.Controls.ListView)(target));
            return;
            case 10:
            this.Time = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            this.Total = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

