﻿#pragma checksum "..\..\..\cabinet.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82281B5142C40CC88B7832C8771E01F9337341A8"
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
    /// cabinet
    /// </summary>
    public partial class cabinet : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserAndTask;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChechTask;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChechUser;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\cabinet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateReportBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/trevel;component/cabinet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\cabinet.xaml"
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
            this.UserAndTask = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\cabinet.xaml"
            this.UserAndTask.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UserAndTask_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\cabinet.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChechTask = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\cabinet.xaml"
            this.ChechTask.Click += new System.Windows.RoutedEventHandler(this.ChechTask_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ChechUser = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\cabinet.xaml"
            this.ChechUser.Click += new System.Windows.RoutedEventHandler(this.CheckUser_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CreateReportBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\cabinet.xaml"
            this.CreateReportBtn.Click += new System.Windows.RoutedEventHandler(this.CreateReportBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

