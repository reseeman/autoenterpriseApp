﻿#pragma checksum "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B6C65D50FAA15BD6010A0B164BB40879C97F94A76B938A5B37D8B62D853ACE2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoenterpriseApp.Pages.PagesAdd;
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


namespace AutoenterpriseApp.Pages.PagesAdd {
    
    
    /// <summary>
    /// PageAddTransportType
    /// </summary>
    public partial class PageAddTransportType : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxName;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxCapacity;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTransportType;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoenterpriseApp;component/pages/pagesadd/pageaddtransporttype.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
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
            this.TbxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TbxCapacity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnAddTransportType = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
            this.btnAddTransportType.Click += new System.Windows.RoutedEventHandler(this.buttonAddTransportType);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 40 "..\..\..\..\Pages\PagesAdd\PageAddTransportType.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

