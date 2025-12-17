using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMAUIApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class UpdateableCollectionViewModel : ObservableObject
    {
        [ObservableProperty] private bool isBusy;
        [ObservableProperty] private bool title;

        [ObservableProperty]
        private ObservableCollection<MarvelMoviesModel> movieCollection = new();

        public object RefreshCommand { get; private set; }

        public UpdateableCollectionViewModel()
        {
            Title = TitleCollections.CollectionTitle;
            
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameofMovie;
                var idx = movieCollection.ToList()
                                         .FindIndex(x => x.NameofMovie == oldTitle); 
                if (idx >= 0)
                {
                    movieCollection[idx] = m.NewValue;
                }
            });

            RefreshCommand.Execute(null);
        }

        [RelayCommand]
        private async Task Refresh()
        {
            if (IsBusy) return;
            isBusy = true; 
            
            await Task.Delay(2000); // Simulate a data fetch delay
            var movies = MovieDataStore.GetMarvelMovies();
            MovieCollection.Clear();

            foreach (var mov in MarvelMoviesModel.GetMovies())
                {
                 MovieCollection.Add(mov);
                
            });
                isBusy = false;
            
        }

        [RelayCommand]
        private async Task Add()
        {
            await.Shell.Current.DisplayAlerty("Debug", "UpdateableCollectionViewMode.Add() called", "OK");

            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    MovieCollection.Add(m.NewMovie);
                });

                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });

            await Shell.Current.GoToAsync(nameof(AddCollectionPage));
        }

        [RelayCommand]
        private async Task Update(MarvelMoviesModel movie)
        {
            string encodedName = Uri.EscapeDataString(movie.NameofMovie);
            await Shell.Current.GoToAsync($"{nameof(EditCollectionPage)}?MovieName={encodedName}");
        }

        [RelayCommand]
        private void Delete(MarvelMoviesModel movie)
        {
            movieCollection.Remove(movie);
        }
    }
}
