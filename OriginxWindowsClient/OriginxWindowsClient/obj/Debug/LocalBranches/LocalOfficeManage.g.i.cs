﻿#pragma checksum "..\..\..\LocalBranches\LocalOfficeManage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0E79A80DFE296520B514C2A58C4293D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace OriginxWindowsClient.LocalBranches {
    
    
    /// <summary>
    /// LocalOfficeManage
    /// </summary>
    public partial class LocalOfficeManage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox coutrybranchcode;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox branchadmin;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox branchcity;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox branchdec;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label coutrybranchcode1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
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
            System.Uri resourceLocater = new System.Uri("/OriginxWindowsClient;component/localbranches/localofficemanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
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
            this.coutrybranchcode = ((System.Windows.Controls.TextBox)(target));
            
            #line 6 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
            this.coutrybranchcode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.coutrybranchcode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.branchadmin = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
            this.branchadmin.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.branchcity = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
            this.branchcity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.branchdec = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.coutrybranchcode1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\LocalBranches\LocalOfficeManage.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

