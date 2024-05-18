using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0404.Models
{
    public class News
    {
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public News(string text, DateTime publishdate)
        {
            Text = text;
            PublishDate = publishdate;
        }
    }
}
