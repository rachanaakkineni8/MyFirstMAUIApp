using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsMainStepperViewModel : ObservableObject
    {
        [ObservableProperty]
        private string xAML = TitleControlsStepper.StepperXAML;

        [ObservableProperty]
        private string vM = TitleControlsMainSlider.VM;

        public ControlsMainStepperViewModel()
        {
        }

        [RelayCommand]
        private async Task XAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperMenu));
        }

        [RelayCommand]
        private async Task VMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsVMStepperMenu));
        }
    }
}
