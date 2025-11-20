using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleImages.Title;

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

        [RelayCommand]
        private async Task EmbeddedImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorClicked()
        {
          
        }
    }
}