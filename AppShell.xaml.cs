using MyFirstMAUIApp.View;

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
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
        }
    }
}
