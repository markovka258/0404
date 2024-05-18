using _0404.Models;
using System;
using System.Collections.Generic;

namespace _0404.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public MainWindowViewModel()
        {
            Blogs = [
                new("Title", "amet, consectetur adipiscing elit. Vivamus ipsum purus, tempor vitae vehicula vitae, ornare sit amet lacus. Vivamus dolor mauris,", ["tag 1, tag 2"], "image1.png"),
                new("Title 2", "a accumsan est auctor at. Aliquam erat volutpat. Pellentesque porttitor dolor enim, eget commodo ", ["tag 3, tag 4"], "image1.png")
                ];

            News =
            [
                new("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus ipsum purus, tempor vitae vehicula vitae,", DateTime.Now),
                new("Vestibulum sagittis justo velit, a accumsan est auctor at. Aliquam erat volutpat. Pellentesque porttitor dolor enim, eget commodo nibh.", DateTime.Today)

                ];
        }
        

#pragma warning restore CA1822 // Mark members as static
        public List<Blogs> Blogs { get; set; }
        public List<News> News { get; set; }
    }
}
