using MyFirstMAUIApp.View;
using MyFirstMAUIApp.ViewModel;
using ControlsMenu = MyFirstMAUIApp.View.ControlsMenu;
using ControlSwitchesPage = MyFirstMAUIApp.View.ControlSwitchesPage;
using ControlSwitchVMPage = MyFirstMAUIApp.View.ControlSwitchVMPage;
using ControlSwitchXAMLPage = MyFirstMAUIApp.View.ControlSwitchXAMLPage;

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
            Routing.RegisterRoute(nameof(LayoutAbsoluteStackPage), typeof(LayoutAbsoluteStackPage));
            Routing.RegisterRoute(nameof(LayoutFlex), typeof(LayoutFlex));
            //Images
            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));

            //Controls
            Routing.RegisterRoute(nameof(ControlsMenu), typeof(ControlsMenu));
            Routing.RegisterRoute(nameof(ControlsMainSliderMenu), typeof(ControlsMainSliderMenu));
            Routing.RegisterRoute(nameof(ControlsSliderMenu), typeof(ControlsSliderMenu));
            Routing.RegisterRoute(nameof(ControlsVMSliderMenu), typeof(ControlsVMSliderMenu));

            Routing.RegisterRoute(nameof(ControlsMainStepperMenu), typeof(ControlsMainStepperMenu));
            Routing.RegisterRoute(nameof(ControlsStepperMenu), typeof(ControlsStepperMenu));
            Routing.RegisterRoute(nameof(ControlsVMStepperMenu), typeof(ControlsVMStepperMenu));

            Routing.RegisterRoute(nameof(ControlSwitchesPage), typeof(ControlSwitchesPage));
            Routing.RegisterRoute(nameof(ControlSwitchXAMLPage), typeof(ControlSwitchXAMLPage));
            Routing.RegisterRoute(nameof(ControlSwitchVMPage), typeof(ControlSwitchVMPage));

            Routing.RegisterRoute(nameof(ControlEntriesPage), typeof(ControlEntriesPage));
            Routing.RegisterRoute(nameof(ControlEntryXAMLPage), typeof(ControlEntryXAMLPage));
            Routing.RegisterRoute(nameof(ControlEntryVMPage), typeof(ControlEntryVMPage));
            Routing.RegisterRoute(nameof(ControlEntryResultPage), typeof(ControlEntryResultPage));
        }
    }
}