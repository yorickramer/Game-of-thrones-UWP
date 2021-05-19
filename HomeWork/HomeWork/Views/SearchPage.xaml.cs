using HomeWork.Models;
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
    public sealed partial class SearchPage : Page
    {
        //default konstruktor
        public SearchPage()
        {
            this.InitializeComponent();
        }

        //home gombra kattintva megnyitja a MenuPage oldalt
        private void OnClickHome(object sender, RoutedEventArgs e)
        {
            ViewModel.NavigateToHome();
        }

        //keresés gombra kattintve lefutó metódus, mely beállitja a keresési feltételeket és elvégzi a szűrést
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string[] param = new string[2];
            param[0] = combotype.SelectedItem.ToString();
            param[1] = nameInput.Text.ToString();
            ViewModel.setParam(param);
            ViewModel.Filter();
        }

        //Egy könyv elemre kattintva, megnyitja az adott könyvet részletező oldalt
        private void Book_ItemClick(object sender, ItemClickEventArgs e)
        {
            Book b = (Book)e.ClickedItem;
            ViewModel.NavigateToBook(b.Url);
        }


        //Egy család elemre kattintva, megnyitja az adott családot részletező oldalt
        private void House_ItemClick(object sender, ItemClickEventArgs e)
        {

            House h = (House)e.ClickedItem;
            ViewModel.NavigateToHouse(h.Url);
        }

        //Egy karakter elemre kattintva, megnyitja az adott karaktert részletező oldalt
        private void Character_ItemClick(object sender, ItemClickEventArgs e)
        {

            Character c = (Character)e.ClickedItem;
            ViewModel.NavigateToCharacter(c.Url);
        }

        //oldal megnyitásakor lefutó metódus, ami a kapott argumentum alapján betölti az adatokat
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var parameters = (string[])e.Parameter;
            ViewModel.setParam(parameters);
        }
    }
}
