#pragma checksum "D:\University\Kliens oldali\HomeWork\HomeWork\Views\SearchPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B659EA6B50FFFF404F75A3FA16C824C4"
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
    partial class SearchPage : 
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
            case 2: // Views\SearchPage.xaml line 13
                {
                    this.ViewModel = (global::HomeWork.ViewModels.SearchPageViewModel)(target);
                }
                break;
            case 3: // Views\SearchPage.xaml line 141
                {
                    this.homebtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.homebtn).Click += this.OnClickHome;
                }
                break;
            case 4: // Views\SearchPage.xaml line 123
                {
                    global::Windows.UI.Xaml.Controls.GridView element4 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element4).ItemClick += this.Book_ItemClick;
                }
                break;
            case 6: // Views\SearchPage.xaml line 98
                {
                    global::Windows.UI.Xaml.Controls.GridView element6 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element6).ItemClick += this.House_ItemClick;
                }
                break;
            case 8: // Views\SearchPage.xaml line 72
                {
                    global::Windows.UI.Xaml.Controls.GridView element8 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element8).ItemClick += this.Character_ItemClick;
                }
                break;
            case 10: // Views\SearchPage.xaml line 38
                {
                    this.searchBar = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11: // Views\SearchPage.xaml line 55
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Search_Click;
                }
                break;
            case 12: // Views\SearchPage.xaml line 42
                {
                    this.combotype = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 13: // Views\SearchPage.xaml line 49
                {
                    this.nameInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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

