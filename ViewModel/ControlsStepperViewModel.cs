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
    public partial class ControlsStepperViewModel : ObservableObject
    {
        [ObservableProperty]
        private string stepperXAML = TitleControlsStepper.StepperXAML;
        [ObservableProperty]
        private string stepperVM = TitleControlsStepper.StepperVM;

        public ControlsStepperViewModel()
        {

        }

        [RelayCommand]
        private async Task StepperXAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperMenu));
        }

        [RelayCommand]
        private async Task StepperVMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsVMStepperMenu));
        }

    }
}
