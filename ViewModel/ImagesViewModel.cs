using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsViewModel : ObservableObject
    {

        //public string Layouts { get; set; } = TitleMain.Layouts;

        //Button Commands
        [ObservableProperty]
        private string uRIImages = TitleImages.URIImages;

        [ObservableProperty]
        private string embeddedImages = TitleImages.EmbeddedImages;

        [ObservableProperty]
        private string activityIndicator = TitleImages.ActivityIndicator;


        [RelayCommand]
        private async Task URIImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }
    }
}
