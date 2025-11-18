namespace MyFirstMAUIApp.View;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
		BindingContext = new MyFirstMAUIApp.ViewModel.ImagesViewModel();
	}
}