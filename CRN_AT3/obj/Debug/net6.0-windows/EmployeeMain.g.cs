﻿#pragma checksum "..\..\..\EmployeeMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C1556B2810491DF275402E7BB6455BC6B219CB3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CRN_AT3;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CRN_AT3 {
    
    
    /// <summary>
    /// EmployeeMain
    /// </summary>
    public partial class EmployeeMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SearchEmployeeLabel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchEmployeeTextbox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FillButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Searchrecord;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdvancedSearchrecord;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Insertrecord;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Deleterecord;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Editrecord;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JoinOperation;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EmployeeDataGrid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\EmployeeMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseWindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CRN_AT3;component/employeemain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EmployeeMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SearchEmployeeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.SearchEmployeeTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FillButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\EmployeeMain.xaml"
            this.FillButton.Click += new System.Windows.RoutedEventHandler(this.FillButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Searchrecord = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\EmployeeMain.xaml"
            this.Searchrecord.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AdvancedSearchrecord = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\EmployeeMain.xaml"
            this.AdvancedSearchrecord.Click += new System.Windows.RoutedEventHandler(this.AdvancedSearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Insertrecord = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\EmployeeMain.xaml"
            this.Insertrecord.Click += new System.Windows.RoutedEventHandler(this.InsertButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Deleterecord = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\EmployeeMain.xaml"
            this.Deleterecord.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Editrecord = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\EmployeeMain.xaml"
            this.Editrecord.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.JoinOperation = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\EmployeeMain.xaml"
            this.JoinOperation.Click += new System.Windows.RoutedEventHandler(this.JoinOperationButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EmployeeDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\..\EmployeeMain.xaml"
            this.EmployeeDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EmployeeDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.CloseWindow = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\EmployeeMain.xaml"
            this.CloseWindow.Click += new System.Windows.RoutedEventHandler(this.CloseWindowButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

