﻿#pragma checksum "..\..\AddServicesOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A106C6B07DD73F30341BCCB8930E2C4B7E177F2FD9ED6FBF986D8712755A338E"
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
    /// AddServicesOrder
    /// </summary>
    public partial class AddServicesOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseOrder;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseServices;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseServices1;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseServices2;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BaseServices3;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionAdd;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionPlus;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\AddServicesOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionMinus;
        
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
            System.Uri resourceLocater = new System.Uri("/Okhta Park;component/addservicesorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddServicesOrder.xaml"
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
            this.BaseOrder = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.BaseServices = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.BaseServices1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.BaseServices2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BaseServices3 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ActionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\AddServicesOrder.xaml"
            this.ActionAdd.Click += new System.Windows.RoutedEventHandler(this.ActionAddClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ActionPlus = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\AddServicesOrder.xaml"
            this.ActionPlus.Click += new System.Windows.RoutedEventHandler(this.ActionPlusClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ActionMinus = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\AddServicesOrder.xaml"
            this.ActionMinus.Click += new System.Windows.RoutedEventHandler(this.ActionMinusClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

