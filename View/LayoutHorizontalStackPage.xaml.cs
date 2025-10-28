using MyFirstMAUIApp.ViewModel;
namespace MyFirstMAUIApp.View;

public partial class LayoutHorizontalStackPage : ContentPage
{
	public LayoutHorizontalStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutHorizontalStackViewModel();
	}
}