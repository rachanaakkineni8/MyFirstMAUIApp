using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlEntriesViewModel : ObservableObject
    {

        public string Title => TitleEntry.Title;

        public string EntryVMButtonText => TitleEntry.EntryVMButtonText;

        public string EntryXAMLButtonText => TitleEntry.EntryXAMLButtonText;

        [RelayCommand]
        private async Task EntryVMButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlEntryVMPage));
        }

        [RelayCommand]
        private async Task EntryXAMLButtonClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlEntryXAMLPage));
        }

        public ControlEntriesViewModel()
        {

        }
    }
}
