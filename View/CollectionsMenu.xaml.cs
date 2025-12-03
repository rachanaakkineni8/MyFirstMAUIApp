using System;
using System.Diagnostics;
using Microsoft.Maui.Controls;

namespace MyFirstMAUIApp.View
{
    public partial class CollectionsMenu : ContentPage
    {
        // Remove this property to resolve ambiguity
        // public Layout RootLayout => this.FindByName<Layout>("RootLayout");

        public CollectionsMenu()
        {
            InitializeComponent();
        }

        private async void OnCollectionsButtonClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("CollectionsButton clicked handler invoked");
            await DisplayAlert("Clicked", "Collections button was clicked.", "OK");
        }

        // Fired when the page is loaded - useful to confirm the page is active and inputs are enabled
        private void OnPageLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine($"CollectionsMenu Loaded. Button IsEnabled={CollectionsButton.IsEnabled}, Root InputTransparent={RootLayout.InputTransparent}");
            // Ensure the button is enabled and the layout accepts input
            CollectionsButton.IsEnabled = true;
            RootLayout.InputTransparent = false;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("CollectionsMenu OnAppearing() called");
        }
    }
}