﻿#pragma checksum "..\..\AddEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0191F02A4717607C6A1A1D7424CADE659B5B41DFA0908643EF339C059ABCC04C"
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
    /// AddEmployee
    /// </summary>
    public partial class AddEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodeEmployee;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Post;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Fname;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sname;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Photo;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditPhoto;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionAdd;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\AddEmployee.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Okhta Park;component/addemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEmployee.xaml"
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
            this.CodeEmployee = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\AddEmployee.xaml"
            this.CodeEmployee.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.FormatPreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Post = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Fname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Sname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Photo = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.EditPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\AddEmployee.xaml"
            this.EditPhoto.Click += new System.Windows.RoutedEventHandler(this.EditPhotoClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ActionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\AddEmployee.xaml"
            this.ActionAdd.Click += new System.Windows.RoutedEventHandler(this.ActionAddClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ActionOut = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\AddEmployee.xaml"
            this.ActionOut.Click += new System.Windows.RoutedEventHandler(this.ActionOutClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

