using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammableWebAPI.Models
{
    public class Category
    {
        public string Title { get; set; }

        public Category(string title)
        {
            Title = title;
        }
    }
}
