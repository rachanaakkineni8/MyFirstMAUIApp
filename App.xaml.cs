using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new MainView();
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new AppShell();
        }
    }
}
