﻿#pragma checksum "D:\现操\Homework3\Homework2\New_page.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9FB02DE545F20D82CF1765F2838CD532"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homework2
{
    partial class New_page : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element1 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 12 "..\..\..\New_page.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element1).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.DeleteAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 18 "..\..\..\New_page.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DeleteAppBarButton).Click += this.DeleteButton_Clicked;
                    #line default
                }
                break;
            case 3:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.myImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 6:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.details = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.dueDate = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 9:
                {
                    this.createButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\New_page.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.createButton).Click += this.createButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.cancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 51 "..\..\..\New_page.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelButton).Click += this.cancelButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.SelectPictureButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 44 "..\..\..\New_page.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SelectPictureButton).Click += this.SelectPictureButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

