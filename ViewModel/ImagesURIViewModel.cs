using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using Microsoft.Maui.Controls;
using System;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesURIViewModel : ObservableObject
    {
        public string Title => TitleImagesURI.Title;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public ImagesURIViewModel()
        {
            imageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleImagesURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }
    }
}