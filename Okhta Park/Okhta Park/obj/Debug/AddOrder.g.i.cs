﻿#pragma checksum "..\..\AddOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1C4E33AC3AAF2AB9DD67BC1489A9528633325001E3389EB9CB6DDC6A5A1471B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Okhta_Park;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace Okhta_Park {
    
    
    /// <summary>
    /// AddOrder
    /// </summary>
    public partial class AddOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderCode;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker OrderDate;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker OrderTime;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseClient;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseStatus;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OrderTimetxt;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionAdd;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\AddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionOut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Okhta Park;component/addorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddOrder.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.OrderCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.OrderDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.OrderTime = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 4:
            this.BaseClient = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BaseStatus = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.OrderTimetxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ActionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AddOrder.xaml"
            this.ActionAdd.Click += new System.Windows.RoutedEventHandler(this.ActionAddClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ActionOut = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\AddOrder.xaml"
            this.ActionOut.Click += new System.Windows.RoutedEventHandler(this.ActionOutClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
