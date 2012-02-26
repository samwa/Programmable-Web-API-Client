using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ProgrammableWebAPI.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Uri { get; set; }

        public Author(JObject jObject)
        {
            Name = (string)jObject["name"];
            Uri = (string)jObject["uri"];
        }
    }
}
