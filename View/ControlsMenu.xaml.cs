using MyFirstMAUIApp.ViewModel;
using System.Diagnostics;

namespace MyFirstMAUIApp.View;

public partial class ControlsMenu : ContentPage
{
    public ControlsMenu()
    {
        InitializeComponent();
        BindingContext = new ControlsViewModel();
    }

    private async void OnSliderButtonClicked(object sender, EventArgs e)
    {
        Debug.WriteLine("OnSliderButtonClicked fired");
        await DisplayAlert("Debug", "Slider button clicked", "OK");

        // Directly invoke VM command as a fallback test
        if (BindingContext is ControlsViewModel vm)
        {
            var cmd = vm.SliderClickedCommand;
            if (cmd != null && cmd.CanExecute(null))
                cmd.Execute(null);
        }
    }
}