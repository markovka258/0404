using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404.Models
{
    public class Blogs
    {
        public string Text { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public string Imagepath {  get; set; }

        public Blogs(string title, string text, string[] tags, string image)
        {
            Title = title;
            Text = text;
            Tags = tags;
            Imagepath = image;
        }
    }
}
