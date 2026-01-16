using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace MyFirstMAUIApp.View
{
    public partial class ControlSwitchXAMLPage : ContentPage
    {
        public ControlSwitchXAMLPage()
        {
            InitializeComponent();

        }

        private void OnSwitchToggled(object sender, ToggledEventArgs e)
        {
        
            label.TextColor = e.Value ? Colors.Blue : Colors.Red;
        }
    }
}