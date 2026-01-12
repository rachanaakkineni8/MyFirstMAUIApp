using MyFirstMAUIApp.ViewModels;

namespace MyFirstMAUIApp.View;

public partial class ControlsMainSliderMenu : ContentPage
{
    public ControlsMainSliderMenu()
    {
        InitializeComponent();
        BindingContext = new ControlsMainSliderViewModel();
    }
}