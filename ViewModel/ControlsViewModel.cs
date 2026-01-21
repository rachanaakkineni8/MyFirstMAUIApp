using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using static MyFirstMAUIApp.View.ControlsMainSliderMenu;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string slider = TitleControls.Slider;

        [ObservableProperty]
        private string stepper = TitleControls.Stepper;

        [ObservableProperty]
        private string notSwitch = TitleControls.NotSwitch;

        [ObservableProperty]
        private string entry = TitleControls.Entry;

        [ObservableProperty]
        private string picker = TitleControls.Picker;

        [ObservableProperty]
        private string dateAndTimePicker = TitleControls.DateAndTimePicker;

        [RelayCommand]
        public async Task SliderClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsMainSliderMenu));
        }

        [RelayCommand]
        public async Task StepperClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsMainStepperMenu));
        }

        [RelayCommand]
        public async Task SwitchClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSwitchesPage));
        }

        [RelayCommand]
        public async Task EntryClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlEntriesPage));
        }
        public ControlsViewModel()
        {

        }
    }
}
