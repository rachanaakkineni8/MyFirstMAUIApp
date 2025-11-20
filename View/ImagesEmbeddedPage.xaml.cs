using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View;

public partial class ImagesEmbeddedPage : ContentPage
{
	public ImagesEmbeddedPage()
	{
		InitializeComponent();
		BindingContext = new ImagesEmbeddedViewModel();
	}
}