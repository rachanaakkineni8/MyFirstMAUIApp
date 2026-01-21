using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;
public partial class ControlEntryXAMLPage : ContentPage
{

    public ControlEntryXAMLPage()
    {
        InitializeComponent();
        BindingContext = new ControlEntryXAMLViewModel();
    }

    private async void SubmitClicked(object sender, EventArgs e)
    {
        string entryText = EntryValue.Text;

        if (string.IsNullOrWhiteSpace(entryText))
        {

            //OLD-> Application.Current.MainPage.DisplayAlert(TitlesEntry.EntryXAMLTitle,"Entry is empty", "Please enter text.", "OK");
            //
            //Entry is empty, show an alert
            await Shell.Current.DisplayAlert(TitleEntry.EntryXAMLTitle, "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            //OLD-> Application.Current.MainPage.DisplayAlert(TitlesEntry.EntryXAMLTitle, "You entered: + entryText", "OK");
            //
            //Entry is not empty, notify the user of what they typed 

            await Shell.Current.DisplayAlert(TitleEntry.EntryXAMLTitle, "You entered: " + entryText, "OK");
        }
    }
}