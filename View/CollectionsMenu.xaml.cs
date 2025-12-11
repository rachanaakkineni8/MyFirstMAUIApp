using MyFirstMAUIApp.ViewModel;

namespace MyFirstMAUIApp.View
{
    public partial class CollectionsMenu : ContentPage
    {
        public CollectionsMenu()
        {
            InitializeComponent();
            BindingContext = new CollectionsMenuViewModel();
        }
    }
}
