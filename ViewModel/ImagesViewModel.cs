using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        public string ImagesURI { get; } = TitleImages.ImagesURI;

        [RelayCommand]
        private async Task ImagesURIClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURI));
        }
    }
}
