using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace MyFirstMAUIApp.ViewModels
{
    public partial class ImagesActivityIndicatorViewModel : ObservableObject
    {
        public string Title => TitleActivityIndicator.ActivityIndicatorTitle;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ImagesActivityIndicatorViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                using var response = await client.GetAsync(TitleActivityIndicator.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var bytes = await response.Content.ReadAsByteArrayAsync();

                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        LoadedImage = ImageSource.FromStream(() => new MemoryStream(bytes));
                        IsImageVisible = true;
                    });
                }
                else
                {
                    Console.WriteLine($"Image request failed: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex}");
            }
            finally
            {
                MainThread.BeginInvokeOnMainThread(() => IsLoading = false);
            }
        }
    }
}



