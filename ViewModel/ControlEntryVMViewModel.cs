using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlEntryVMViewModel : ObservableObject
    {

        public string Title => TitleControlEntryVM.Title;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            await Shell.Current.GoToAsync($"{nameof(ControlEntryResultPage)}?entryText={EntryText}");
        }

        public ControlEntryVMViewModel()
        {

        }
    }
}
