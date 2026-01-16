using Microsoft.Maui.Controls;
using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlSwitchVMPage : ContentPage
{
    public ControlSwitchVMPage()
    {
        InitializeComponent();
        BindingContext = new ControlSwitchVMViewModel();
    }
}