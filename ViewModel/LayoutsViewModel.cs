using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMAUIApp.Models.Titles;
using MyFirstMAUIApp.View;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutsViewModel : ObservableObject
    {

        //public string Layouts { get; set; } = TitleMain.Layouts;

        //Button Commands
        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;

        [ObservableProperty]
        private string verticalStack = TitleLayouts.VerticalStack;

        [ObservableProperty]
        private string horizontalStack = TitleLayouts.HorizontalStack;

        [ObservableProperty]
        private string absoluteLayout = TitleLayouts.AbsoluteLayout;

        [RelayCommand]
        private async Task StackLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutStackPage));
        }

        [RelayCommand]
        public async Task VerticalLayoutStackClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutVerticalStackPage));
        }
        [RelayCommand]
        public async Task HorizontalLayoutStackClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutHorizontalStackPage));
        }

        public LayoutsViewModel()
        {

        }
    }
}
