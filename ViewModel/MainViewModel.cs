using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMAUIApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {


        //public string Layouts { get; set; } = TitleMain.Layouts;

        //Button Commands
        [ObservableProperty]
        private string layouts = TitleMain.Layouts;

        [ObservableProperty]
        private string images = TitleMain.Images;

        [ObservableProperty]
        private string collections = TitleMain.Collections;

        [ObservableProperty]
        private string controls = TitleMain.Controls;

        [ObservableProperty]
        private string sqlite = TitleMain.SQLlite;

     

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        // Add command for Collections button
        [RelayCommand]
        private async Task CollectionsClicked()
        {
            // Navigate using the registered route name
            await Shell.Current.GoToAsync(nameof(CollectionsMenu));
        }

        [RelayCommand]
        private async Task ControlsClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsMenu));
        }

        public MainViewModel()
        {

        }
    }
}