﻿#pragma checksum "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D1F3C9901F4CC8A19E6ABA1C24886758BAA7C307ECB92E2D318FEF9F58C8306"
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
    /// PageAddBrigadier
    /// </summary>
    public partial class PageAddBrigadier : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbxFIO;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbBrigadeChoise;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddBrigadier;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoenterpriseApp;component/pages/pagesadd/pageaddbrigadier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
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
            this.TbxFIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CmbBrigadeChoise = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnAddBrigadier = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
            this.btnAddBrigadier.Click += new System.Windows.RoutedEventHandler(this.buttonAddBrigadier);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 43 "..\..\..\..\Pages\PagesAdd\PageAddBrigadier.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

