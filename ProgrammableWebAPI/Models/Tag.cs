using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammableWebAPI.Models
{
    public class Tag
    {
        public string Title { get; set; }

        public Tag(string title)
        {
            Title = title;
        }
    }
}
