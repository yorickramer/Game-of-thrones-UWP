using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace HomeWork.Views
{
    public sealed partial class BookDetailsPage : Page
    {
        //default konstruktor
        public BookDetailsPage()
        {
            this.InitializeComponent();
        }

        //oldal megnyitásakor lefutó metódus, ami a kapott argumentum alapján betölti az adatokat
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameters = (string)e.Parameter;
            ViewModel.LoadBookAsync(parameters);
        }

        //Egy karakter elemre kattintva, megnyitja az adott karaktert részletező oldalt
        private void Characters_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToCharacters(e.ClickedItem.ToString());
        }

        //home gombra kattintva megnyitja a MenuPage oldalt
        private void OnClickHome(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToHome();
        }
    }
}
