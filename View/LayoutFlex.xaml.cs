using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class LayoutFlex : ContentPage
{
	public LayoutFlex()
	{
		InitializeComponent();
		BindingContext = new LayoutFlexViewModel();
	}
}