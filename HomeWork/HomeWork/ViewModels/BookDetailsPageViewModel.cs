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
    class BookDetailsPageViewModel : ViewModelBase
    {
        //könyv property
        private Book _book;
        public Book book
        {
            get { return _book; }
            set { Set(ref _book, value); }
        }
        private Service service = new Service();
        private Frame rootFrame = Window.Current.Content as Frame;

        
        public BookDetailsPageViewModel(){}

        //kapott url alapján betölti a megfelelő könyvet
        internal async Task LoadBookAsync(string parameter)
        {
            int id = service.GetID(parameter);
            book = await service.GetBookAsync(id);
        }

        //kapott url-t továbbadva, megnyitja a CharacterDetailsPage oldalt
        public void NavigateToCharacters(string parameter)
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
