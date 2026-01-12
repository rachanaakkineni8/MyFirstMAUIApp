using Microsoft.Maui.Controls;
using MyFirstMAUIApp.ViewModels;
namespace MyFirstMAUIApp.View;

public partial class ControlsVMSliderMenu : ContentPage
{
    public ControlsVMSliderMenu()
    {
        InitializeComponent();
        BindingContext = new ControlsVMSliderViewModel();
    }
}