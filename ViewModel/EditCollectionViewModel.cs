using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIApp.Models.Entities;
using MyFirstMAUIApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class EditCollectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleMisc.EditTitle;

        [ObservableProperty]
        private string movieName = string.Empty;

        public EditCollectionViewModel()
        {

        }

        [Relaycommand]
        private async Task UpdateBtnClicked()
        {
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                await Shell.Current.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            var movie = new MarvelMoviesModel { NameofMovie = MovieName };
            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(
                new MarvelMoviesModel { NameofMovie = string.Empty }
                movie));    

            await Shell.Current.GoToAsync("..");    
        }
    }
    {
    }
}
