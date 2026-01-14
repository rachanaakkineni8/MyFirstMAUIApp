using Microsoft.Maui.Controls;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlsVMSliderMenu : ContentPage
{
    public ControlsVMSliderMenu()
    {
        InitializeComponent();
        BindingContext = new ControlsVMSliderViewModel();
    }
}