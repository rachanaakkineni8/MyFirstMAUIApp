using Microsoft.Maui.Controls;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlSwitchesPage : ContentPage
{
    public ControlSwitchesPage()
    {
        InitializeComponent();
        BindingContext = new ControlSwitchesViewModel();
    }
}