﻿#pragma checksum "..\..\..\AppWindows\AddToBlackListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40090A92D52F792AACDF38877BA5AD559CDB3D702473F9778738727793067EC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DepartmentEmployeesTerminal.AppWindows;
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


namespace DepartmentEmployeesTerminal.AppWindows {
    
    
    /// <summary>
    /// AddToBlackListWindow
    /// </summary>
    public partial class AddToBlackListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBFullName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBReason;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAgree;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/DepartmentEmployeesTerminal;component/appwindows/addtoblacklistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
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
            this.TBFullName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TBReason = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BAgree = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
            this.BAgree.Click += new System.Windows.RoutedEventHandler(this.BAgree_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BCancel = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\AppWindows\AddToBlackListWindow.xaml"
            this.BCancel.Click += new System.Windows.RoutedEventHandler(this.BCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

