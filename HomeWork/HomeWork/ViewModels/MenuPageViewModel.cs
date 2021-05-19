using GalaSoft.MvvmLight;
using HomeWork.Models;
using HomeWork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HomeWork.ViewModels
{
    class MenuPageViewModel  : ViewModelBase
    {
        //könyvlista property
        private List<Book> _books;
        public List<Book> books
        {
            get { return _books; }
            set { Set(ref _books, value); }
        }

        //családlista property
        private List<House> _houses;
        public List<House> houses
        {
            get { return _houses; }
            set { Set(ref _houses, value); }
        }

        //karakterlista property
        private List<Character> _characters;
        public List<Character> characters
        {
            get { return _characters; }
            set { Set(ref _characters, value); }
        }

        private Service service = new Service();
        private Frame rootFrame = Window.Current.Content as Frame;

        //default konstruktor
        public MenuPageViewModel()
        {
            LoadPage(1, 10);
        }


        //aszinkron metódus ami betölti a listákat
        public async Task LoadPage(int page, int pagesize)
        {
            characters = await service.GetCharactersAsync(page, pagesize);
            books = await service.GetBooksAsync(page, pagesize);
            houses = await service.GethousesAsync(page, pagesize);
        }

        //kapott url-t továbbadva, megnyitja a BookDetailsPage oldalt
        public void NavigateToBook(string parameter)
        {
            rootFrame.Navigate(typeof(Views.BookDetailsPage), parameter);
        }

        //kapott url-t továbbadva, megnyitja a HouseDetailsPage oldalt
        public void NavigateToHouse(string parameter)
        {
            rootFrame.Navigate(typeof(Views.HouseDetailsPage), parameter);
        }

        //kapott url-t továbbadva, megnyitja a CharacterDetailsPage oldalt
        public void NavigateToCharacter(string parameter)
        {
            rootFrame.Navigate(typeof(Views.CharacterDetailsPage), parameter);
        }

        //kapott string[] továbbadva, megnyitja a SearchPage oldalt. A paraméter 
        //tartalmazza a keresési szót, és a keresés tipusát
        public void NavigateToSearch(string[] parameter)
        {
            rootFrame.Navigate(typeof(Views.SearchPage), parameter);
        }

        //A MenuPage oldalon az utolsó oldal megtalálása miatt kell
        public bool HasItem()
        {
            if (books == null || houses == null || characters == null)
                return false;
            if (books.Count < 10 && houses.Count < 10 && characters.Count < 10)
                return false;
            return true;
        }
    }
}
