﻿#pragma checksum "..\..\..\Window\WindowNessary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C861C3BCB3114A61C2AF04AE6714415726A78636253862B33262472509714A76"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AppFermer.Window;
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


namespace AppFermer.Window {
    
    
    /// <summary>
    /// WindowNessary
    /// </summary>
    public partial class WindowNessary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Canvas;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbNameFermer;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbTypeNessary;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbTextNessary;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtDateToday;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreateNessary;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Window\WindowNessary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPrintNessary;
        
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
            System.Uri resourceLocater = new System.Uri("/AppFermer;component/window/windownessary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window\WindowNessary.xaml"
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
            this.Canvas = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CmbNameFermer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CmbTypeNessary = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TxbTextNessary = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtDateToday = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BtnCreateNessary = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\Window\WindowNessary.xaml"
            this.BtnCreateNessary.Click += new System.Windows.RoutedEventHandler(this.BtnCreateNessary_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnPrintNessary = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\Window\WindowNessary.xaml"
            this.BtnPrintNessary.Click += new System.Windows.RoutedEventHandler(this.BtnPrintNessary_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

