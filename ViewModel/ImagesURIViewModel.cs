using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesURIViewModel : ObservableObject
    {
        public string Title => TitleImages.URIImagesTitle;

        [ObservableProperty]
        private ImageSource imageSourceUrl;
        public ImagesURIViewModel()
        {
            imagesSourceUrl = new UriImageSourceService
            {
                Uri = new Uri(TitleImagesURI.ImagesURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }
    }
}
