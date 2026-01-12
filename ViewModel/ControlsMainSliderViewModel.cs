using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModels
{
    public partial class ControlsMainSliderViewModel : ObservableObject
    {
        [ObservableProperty]
        private string xAML = TitleControlsMainSlider.XAML;

        [ObservableProperty]
        private string vM = TitleControlsMainSlider.VM;

        public ControlsMainSliderViewModel()
        {
        }

        [RelayCommand]
        private async Task XAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderMenu));
        }

        [RelayCommand]
        private async Task VMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsVMSliderMenu));
        }
    }
}