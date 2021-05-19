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

    public sealed partial class MenuPage : Page
    {
        //oldalszám, oldalméret
        int page = 1, pagesize = 10;

        //default konstruktor
        public MenuPage()
        {
            this.InitializeComponent();
        }

        //keresés gombra kattintve lefutó metódus, mely a keresési feltételeket paraméterként továbbadva megnyitja a SearchPage oldalt
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string[] param = new string[2];
            param[0] = combotype.SelectedItem.ToString();
            param[1] = nameInput.Text.ToString();
            ViewModel.NavigateToSearch(param);
        }

        //Search gombra kattintva megnyitja a keresési részt
        private void SearchBar_Click(object sender, RoutedEventArgs e)
        {
            searchBarBtn.Visibility = Visibility.Collapsed;
            searchBar.Visibility = Visibility.Visible;
        }

        //Cancel gombra kattintva bezárja a keresési részt
        private void SearchBarCancel_Click(object sender, RoutedEventArgs e)
        {
            searchBarBtn.Visibility = Visibility.Visible;
            searchBar.Visibility = Visibility.Collapsed;
        }

        //oldalméretet beállitó metódus
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pagesize = (int)e.AddedItems[0];
        }

        //next gombra kattintva betölti a következő oldal adatait
        private void OnClickNext(object sender, RoutedEventArgs e)
        {
            page++;
            ViewModel.LoadPage(page,pagesize);
            btnprevous.Visibility = Visibility.Visible;
            pagenum.Text = "Page: " + page.ToString();
            if (!ViewModel.HasItem())
                btnnext.Visibility = Visibility.Collapsed;
        }

        //prevous gombra kattintva betölti az előző oldal adatait
        private void OnClickPrev(object sender, RoutedEventArgs e)
        {
            page--;
            ViewModel.LoadPage(page, pagesize);
            pagenum.Text = "Page: " + page.ToString();
            if (page==1)
                btnprevous.Visibility = Visibility.Collapsed;
            btnnext.Visibility = Visibility.Visible;
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
    }
}
