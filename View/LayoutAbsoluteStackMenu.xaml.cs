using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class LayoutAbsoluteStackPage : ContentPage
{
	public LayoutAbsoluteStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutAbsoluteStackViewModel();
	}
}