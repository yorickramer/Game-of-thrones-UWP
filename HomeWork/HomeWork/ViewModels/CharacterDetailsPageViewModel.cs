
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
    class CharacterDetailsPageViewModel : ViewModelBase
    {
        //karakter property
        private Character _character;
        public Character character
        {
            get { return _character; }
            set { Set(ref _character, value);  }
        }

        private Service service = new Service();
        private Frame rootFrame = Window.Current.Content as Frame;


        public CharacterDetailsPageViewModel(){}

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

        //kezdőoldalra navigál, megnyitva a MenuPage oldalt
        public void NavigateToHome()
        {
            rootFrame.Navigate(typeof(Views.MenuPage));
        }

        //kapott url alapján betölti a megfelelő karaktert
        internal async Task LoadCharacterAsync(string parameter)
        {

            rootFrame.Navigate(typeof(Views.CharacterDetailsPage), parameter);
            int id = service.GetID(parameter);
            character = await service.GetCharacterAsync(id);
            
        }

        public void NavigateToCharacter(string parameter)
        {
            rootFrame.Navigate(typeof(Views.CharacterDetailsPage), parameter);
        }


    }
}
