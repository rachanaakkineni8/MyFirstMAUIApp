using MyFirstMAUIApp.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    class LayoutsViewModel
    {
        public string StackLayout { get; set; } = TitleLayouts.StackLayout;

        public string HorizontalStack { get; set; } = TitleLayouts.HorizontalStack;

        public string VerticalStack { get; set; } = TitleLayouts.VerticalStack;

        public string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;

    }
}
