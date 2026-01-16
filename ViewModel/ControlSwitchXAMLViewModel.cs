using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlSwitchXAMLViewModel : ObservableObject
    {
        public string Title => TitleControlSwitchXAML.Title;

        public ControlSwitchXAMLViewModel()
        {

        }

    }
}
