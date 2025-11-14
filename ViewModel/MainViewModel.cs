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
        private string sqlite = TitleMain.SQLlite;

        [ObservableProperty]
        private string controls = TitleMain.Controls;

        
        [RelayCommand]

        //public ICommand OnLayoutsClicked { get; set; }
       

        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));  
        }

        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        public MainViewModel()
        {
          
        }
    }
}
