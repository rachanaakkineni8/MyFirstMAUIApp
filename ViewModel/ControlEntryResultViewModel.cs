using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    [QueryProperty(nameof(EntryText), "entryText")]
    public partial class ControlEntryResultViewModel : ObservableObject
    {

        public string Title => TitleControlEntryResult.Title;

        [ObservableProperty]
        private string entryText;
    }
}
