using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlSwitchesViewModel : ObservableObject
    {
        public string Title => TitleControlSwitches.Title;

        public string SwitchVMButtonText => TitleControlSwitches.SwitchVMButtonText;

        public string SwitchXAMLButtonText => TitleControlSwitches.SwitchXAMLButtonText;

        [RelayCommand]
        private async Task SwitchVMButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSwitchVMPage));
        }

        [RelayCommand]
        private async Task SwitchXAMLButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSwitchXAMLPage));
        }
    }
}
