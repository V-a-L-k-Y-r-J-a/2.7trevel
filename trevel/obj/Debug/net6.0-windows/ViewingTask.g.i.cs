﻿#pragma checksum "..\..\..\ViewingTask.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB4B33599E56A018B1661312CCF87AB987393994"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using trevel;


namespace trevel {
    
    
    /// <summary>
    /// ViewingTask
    /// </summary>
    public partial class ViewingTask : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\ViewingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ViewingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchBtn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ViewingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOutBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ViewingTask.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TaskDGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/trevel;component/viewingtask.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewingTask.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SearchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\ViewingTask.xaml"
            this.SearchBtn.Click += new System.Windows.RoutedEventHandler(this.SearchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogOutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\ViewingTask.xaml"
            this.LogOutBtn.Click += new System.Windows.RoutedEventHandler(this.LogOutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TaskDGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\ViewingTask.xaml"
            this.TaskDGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TaskDGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

