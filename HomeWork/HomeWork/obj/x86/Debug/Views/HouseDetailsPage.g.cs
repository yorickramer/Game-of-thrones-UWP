﻿#pragma checksum "D:\University\Kliens oldali\HomeWork\HomeWork\Views\HouseDetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C7C9D7038E45E9C40CC56E0C1C8BF39E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeWork.Views
{
    partial class HouseDetailsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\HouseDetailsPage.xaml line 13
                {
                    this.ViewModel = (global::HomeWork.ViewModels.HouseDetailsPageViewModel)(target);
                }
                break;
            case 3: // Views\HouseDetailsPage.xaml line 189
                {
                    this.homebtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.homebtn).Click += this.OnClickHome;
                }
                break;
            case 4: // Views\HouseDetailsPage.xaml line 175
                {
                    global::Windows.UI.Xaml.Controls.GridView element4 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element4).ItemClick += this.Character_ItemClick;
                }
                break;
            case 10: // Views\HouseDetailsPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Person_ItemClick;
                }
                break;
            case 11: // Views\HouseDetailsPage.xaml line 76
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.House_ItemClick;
                }
                break;
            case 12: // Views\HouseDetailsPage.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Person_ItemClick;
                }
                break;
            case 13: // Views\HouseDetailsPage.xaml line 63
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.Person_ItemClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

