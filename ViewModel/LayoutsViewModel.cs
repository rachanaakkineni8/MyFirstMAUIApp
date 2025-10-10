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
    public partial class LayoutsViewModel : ObservableObject
    {

        //public string Layouts { get; set; } = TitleMain.Layouts;

        //Button Commands
        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayouts;

        [ObservableProperty]
        private string verticalLayout = TitleLayouts.VerticalLayouts;

        [ObservableProperty]
        private string horizontalLayout = TitleLayouts.HorizontalLayouts;

        [ObservableProperty]
        private string absoluteLayout = TitleLayouts.AbsoluteLayouts;

    


        [RelayCommand]

        //public ICommand OnLayoutsClicked { get; set; }


        private async Task OnLayoutsClickedAsync()
        {
            await Shell.Current.GoToAsync(nameof(LayoutStackPage));
        }

        public LayoutsViewModel()
        {

        }
    }
}
