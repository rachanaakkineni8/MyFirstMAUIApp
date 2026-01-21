using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ControlEntriesPage : ContentPage
{
    public ControlEntriesPage()
    {
        BindingContext = new ControlEntriesViewModel();

        InitializeComponent();
    }
}