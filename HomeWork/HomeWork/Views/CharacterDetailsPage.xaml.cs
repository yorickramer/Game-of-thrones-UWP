using HomeWork.Models;
using HomeWork.ViewModels;
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

    public sealed partial class CharacterDetailsPage : Page
    {
        //default konstruktor
        public CharacterDetailsPage()
        {
            this.InitializeComponent();
        }

        //Egy könyv elemre kattintva, megnyitja az adott könyvet részletező oldalt
        private void Books_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToBook(e.ClickedItem.ToString());
        }

        //Egy karakter elemre kattintva, betölti az adott karaktert
        private void Person_ItemClick(object sender, RoutedEventArgs e)
        {
            string parameter = (sender as Button).AccessKey.ToString();
            if (!parameter.Equals(""))
            {
                ViewModel.LoadCharacterAsync(parameter);
            }
        }

        //Egy család elemre kattintva, megnyitja az adott családot részletező oldalt
        private void House_ItemClick(object sender, ItemClickEventArgs e)
        {
            ViewModel.NavigateToHouse(e.ClickedItem.ToString());
        }

        //oldal megnyitásakor lefutó metódus, ami a kapott argumentum alapján betölti az adatokat
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameters = (string)e.Parameter;
            ViewModel.LoadCharacterAsync(parameters);
        }

        //home gombra kattintva megnyitja a MenuPage oldalt
        private void OnClickHome(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToHome();
        }
    }
}
