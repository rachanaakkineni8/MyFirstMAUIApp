namespace MyFirstMAUIApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(DetailsPage)), typeof(DetailsPage));
            Routing.RegisterRoute(nameof(PickerResultsPage)), typeof(PickerResultsPage));
        }
    }
}
