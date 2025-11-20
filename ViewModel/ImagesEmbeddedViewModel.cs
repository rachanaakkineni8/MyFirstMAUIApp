using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using Microsoft.Maui.Controls;
using System;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesEmbeddedViewModel : ObservableObject
    {
        public string Title => TitleImagesEmbedded.Title;

        // return an ImageSource explicitly so XAML binding gets the correct type
        public ImageSource ImageSource => ImageSource.FromFile("field.jpg");
    }
}