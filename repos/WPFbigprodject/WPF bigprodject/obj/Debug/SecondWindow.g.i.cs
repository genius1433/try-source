﻿#pragma checksum "..\..\SecondWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E522CC3134233B4A9A220041C33C291324FD28486054806B520E4DD512129D7"
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
using WPF_bigprodject;


namespace WPF_bigprodject {
    
    
    /// <summary>
    /// SecondWindow
    /// </summary>
    public partial class SecondWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitToFirstWindow;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BoxToRead;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SellingBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF bigprodject;component/secondwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SecondWindow.xaml"
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
            this.ExitToFirstWindow = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\SecondWindow.xaml"
            this.ExitToFirstWindow.Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BoxToRead = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\SecondWindow.xaml"
            this.BoxToRead.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BoxToRead_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterInPrintCars);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GettingInformationFromAddingCarOrCars);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 18 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterInAdding);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterInSelling);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SellingBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\SecondWindow.xaml"
            this.SellingBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GettingInformationFromSellingCar);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrintListOfCars);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 23 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterInCalculateRevenue);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 24 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GettingInformationFromCalculateRevenue);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 25 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterNewUser);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 28 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.GettingInformationFromSearcher);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 29 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EnterInSearch);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 30 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.ModelAndTransmissionTypeSearchButton);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 31 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.SeatsMunMaxSearchButton);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 32 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.ColourSearchButton);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 33 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.VansSizeSearchButton);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 36 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonReturnToLogin);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 38 "..\..\SecondWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

