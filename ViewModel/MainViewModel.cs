using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstMAUIApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public string Layouts { get; set; } = TitleMain.Layouts;

        //Button Commands

        public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel()
        {
            Title = TitleMain.Title;

            //Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }
   

    }
}
