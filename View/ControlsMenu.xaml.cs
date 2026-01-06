namespace MyFirstMAUIApp.View;

public partial class ControlsMenu : ContentPage
{
	public ControlsMenu()
	{
		InitializeComponent();
		BindingContext = new ControlsViewModel();
	}
}