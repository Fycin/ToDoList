﻿#pragma checksum "..\..\CreateReminder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E2944B57AD19CD0F3006E49AC6219D09EBD001838B42CCB96927C6D71633F9C"
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
using ToDoList;


namespace ToDoList {
    
    
    /// <summary>
    /// CreateReminder
    /// </summary>
    public partial class CreateReminder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\CreateReminder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ToDoList.CreateReminder Window;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\CreateReminder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReminderName;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\CreateReminder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\CreateReminder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextReminder;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\CreateReminder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateReminderButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoList;component/createreminder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateReminder.xaml"
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
            this.Window = ((ToDoList.CreateReminder)(target));
            
            #line 8 "..\..\CreateReminder.xaml"
            this.Window.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 215 "..\..\CreateReminder.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 216 "..\..\CreateReminder.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ReminderName = ((System.Windows.Controls.TextBox)(target));
            
            #line 222 "..\..\CreateReminder.xaml"
            this.ReminderName.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 222 "..\..\CreateReminder.xaml"
            this.ReminderName.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.TextReminder = ((System.Windows.Controls.TextBox)(target));
            
            #line 236 "..\..\CreateReminder.xaml"
            this.TextReminder.LostFocus += new System.Windows.RoutedEventHandler(this.TextReminder_LostFocus);
            
            #line default
            #line hidden
            
            #line 236 "..\..\CreateReminder.xaml"
            this.TextReminder.GotFocus += new System.Windows.RoutedEventHandler(this.TextReminder_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CreateReminderButton = ((System.Windows.Controls.Button)(target));
            
            #line 241 "..\..\CreateReminder.xaml"
            this.CreateReminderButton.Click += new System.Windows.RoutedEventHandler(this.CreateReminderButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
