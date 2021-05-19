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
using Windows.UI.Xaml.Navigation;

namespace HomeWork.ViewModels
{
    class SearchPageViewModel : ViewModelBase
    {
        //szűrt könyvek listája
        private List<Book> _books;
        public List<Book> books
        {
            get { return _books; }
            set { Set(ref _books, value); }
        }

        //szűrt családok listája
        private List<House> _houses;
        public List<House> houses
        {
            get { return _houses; }
            set { Set(ref _houses, value); }
        }

        //szűrt karakterek listája
        private List<Character> _characters;
        public List<Character> characters
        {
            get { return _characters; }
            set { Set(ref _characters, value); }
        }

        //Összes entitások listája
        public List<Book> Allbooks;
        public List<Character> Allchar;
        public List<House> Allhouse;

        //keresési feltételek
        private string search;
        private string type;

        private Service service = new Service();
        private Frame rootFrame = Window.Current.Content as Frame;

        //default konstruktor
        public SearchPageViewModel()
        {
            Load();
        }


        //aszinkron metódus ami betölti az összes entitást a listákba, majd szűr 
        public async Task Load()
        {
            Allchar = await service.GetAllCharactersAsync();
            Allhouse = await service.GetAllHousesAsync();
            Allbooks = await service.GetAllBooksAsync();
            Filter();
        }


        //A kapott string[] alapján beállitja a keresési feltételeket
        public void setParam(string[] param)
        {
            type = param[0];
            search = param[1];
        }

        //A metódus a keresési feltételeknek megfelelő elemeket rakja a books, houses, characters listába
        public void Filter()
        {
            List<Book> books2 = new List<Book>();
            List<House> houses2 = new List<House>();
            List<Character> characters2 = new List<Character>();
            if(type.Equals("Character") || type.Equals("All"))
            {
                for (int i = 0; i < Allchar.Count; i++)
                {
                    if (Allchar[i].Name.Contains(search))
                        characters2.Add(Allchar[i]);
                }
                characters = characters2;
            }
            if (type.Equals("House") || type.Equals("All"))
            {
                for (int i = 0; i < Allhouse.Count; i++)
                {
                    if (Allhouse[i].Name.Contains(search))
                        houses2.Add(Allhouse[i]);
                }
                houses = houses2;
            }
            if (type.Equals("Books") || type.Equals("All"))
            {
                for (int i = 0; i < Allbooks.Count; i++)
                {
                    if (Allbooks[i].Name.Contains(search))
                        books2.Add(Allbooks[i]);
                }
                books = books2;
            }
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

        //kezdőoldalra navigál, megnyitva a MenuPage oldalt
        public void NavigateToHome()
        {
            rootFrame.Navigate(typeof(Views.MenuPage));
        }
    }
}
