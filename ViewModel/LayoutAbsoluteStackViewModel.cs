using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMAUIApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class LayoutAbsoluteStackViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayoutAbsolute.Title;
        public LayoutAbsoluteStackViewModel()
        {
        }
    }
}
