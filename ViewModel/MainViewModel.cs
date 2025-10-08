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
        [RelayCommand]
        //public ICommand OnLayoutsClicked { get; set; }
        private async Task OnLayoutsClickedAsync()
        {

            //public MainViewModel()

            //Title = TitleMain.Title;

            //Set Commands
            //OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        private async Task OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
   
        public MainViewModel()
        {
            TitleMain = TitleMain.Title;
        }
    }
}
