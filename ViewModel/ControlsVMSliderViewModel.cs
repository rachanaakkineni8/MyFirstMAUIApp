using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;
using MyFirstMAUIApp.Models.Titles;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class ControlsVMSliderViewModel : ObservableObject
    {
        public string Title => TitleControlsVMSlider.VM;

        [ObservableProperty]
        private double slider = 0.5;

        [ObservableProperty]
        private double opacity = 0.5;

        // Rename the backing field to avoid ambiguity with generated property
        private readonly ICommand _setToHalfCommand;
        public ICommand SetToHalfCommand => _setToHalfCommand;

        public ControlsVMSliderViewModel()
        {
            _setToHalfCommand = new Command(() =>
            {
                Slider = 0.5;
                Opacity = 0.5;
            });
        }

        partial void OnSliderChanged(double value)
        {
            Opacity = value;
        }
    }
}