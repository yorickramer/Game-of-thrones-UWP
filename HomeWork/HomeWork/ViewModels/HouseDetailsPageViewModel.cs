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
    class HouseDetailsPageViewModel : ViewModelBase
    {
        //család property
        private House _house;
        public House house
        {
            get { return _house; }
            set { Set(ref _house, value); }
        }

        private Service service = new Service();
        private Frame rootFrame = Window.Current.Content as Frame;
        

        public HouseDetailsPageViewModel(){}

        //kapott url alapján betölti a megfelelő családot
        internal async Task LoadHouseAsync(string parameter)
        {
            int id = service.GetID(parameter);
            house = await service.GetHouseAsync(id);

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
