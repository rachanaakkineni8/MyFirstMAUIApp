using MyFirstMAUIApp.View;
using MyFirstMAUIApp.ViewModel;

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
            Routing.RegisterRoute(nameof(LayoutHorizontalStackPage), typeof(LayoutHorizontalStackPage));
            Routing.RegisterRoute(nameof(LayoutVerticalStackPage), typeof(LayoutVerticalStackPage));
        }
    }
}

