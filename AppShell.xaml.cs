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
            //Layouts
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(LayoutStackPage), typeof(LayoutStackPage));
            Routing.RegisterRoute(nameof(VerticalStackLayout), typeof(VerticalStackLayout));
            Routing.RegisterRoute(nameof(HorizontalStackLayout), typeof(HorizontalStackLayout));
        }
    }
}
