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

    public sealed partial class HouseDetailsPage : Page
    {
        //default konstruktor
        public HouseDetailsPage()
        {
            this.InitializeComponent();
        }

        //oldal megnyitásakor lefutó metódus, ami a kapott argumentum alapján betölti az adatokat
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameter = (string)e.Parameter;
            ViewModel.LoadHouseAsync(parameter);
        }

        //Egy karakter elemre kattintva, megnyitja az adott karaktert részletező oldalt
        private void Person_ItemClick(object sender, RoutedEventArgs e)
        {
            string parameter = (sender as Button).AccessKey.ToString();
            ViewModel.NavigateToCharacter(parameter);
        }

        //Egy család elemre kattintva, betölti az adott családot
        private void House_ItemClick(object sender, RoutedEventArgs e)
        {
            string parameter = (sender as Button).Content.ToString();
            ViewModel.LoadHouseAsync(parameter);
        }

        //Egy karakter elemre kattintva, megnyitja az adott karaktert részletező oldalt
        private void Character_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToCharacter(e.ToString());
        }

        //home gombra kattintva megnyitja a MenuPage oldalt
        private void OnClickHome(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToHome();
        }
    }
}
