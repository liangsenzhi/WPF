﻿#pragma checksum "D:\Expression Blend NewBook\Example\SilverlightHtmlHost\SilverlightHtmlHost\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8F6E5C514E8AA485F705C03D184A341"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Divelements.SilverlightTools;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverlightHtmlHost {
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.ScrollViewer LayoutRoot;
        
        internal System.Windows.Controls.TextBlock tb1;
        
        internal System.Windows.Controls.TextBlock tb2;
        
        internal System.Windows.Controls.TextBlock tb3;
        
        internal System.Windows.Controls.TextBlock tb4;
        
        internal System.Windows.Controls.TextBlock tb5;
        
        internal System.Windows.Controls.TextBlock tb6;
        
        internal Divelements.SilverlightTools.HtmlHost host;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverlightHtmlHost;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.ScrollViewer)(this.FindName("LayoutRoot")));
            this.tb1 = ((System.Windows.Controls.TextBlock)(this.FindName("tb1")));
            this.tb2 = ((System.Windows.Controls.TextBlock)(this.FindName("tb2")));
            this.tb3 = ((System.Windows.Controls.TextBlock)(this.FindName("tb3")));
            this.tb4 = ((System.Windows.Controls.TextBlock)(this.FindName("tb4")));
            this.tb5 = ((System.Windows.Controls.TextBlock)(this.FindName("tb5")));
            this.tb6 = ((System.Windows.Controls.TextBlock)(this.FindName("tb6")));
            this.host = ((Divelements.SilverlightTools.HtmlHost)(this.FindName("host")));
        }
    }
}

