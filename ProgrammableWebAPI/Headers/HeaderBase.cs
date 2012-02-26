using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Models;
using Newtonsoft.Json.Linq;
using ProgrammableWebAPI.Extensions;

namespace ProgrammableWebAPI.Headers
{
    public class HeaderBase
    {
        public DateTime Updated { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Link { get; set; }
        public string Logo { get; set; }
        public Author Author { get; set; }
        public string Generator { get; set; }
        public string GeneratorName { get; set; }
        public int TotalResults { get; set; }
        public int StartIndex { get; set; }
        public int ItemsPerPage { get; set; }

        public HeaderBase(JObject jObject)
        {
            Updated = DateTime.Parse((string)jObject["updated"]);
            Title = (string)jObject["title"];
            Subtitle = (string)jObject["subtitle"];
            Link = (string)jObject["link"];
            Logo = (string)jObject["logo"];
            Author = new Author((JObject)jObject["author"]);
            Generator = (string)jObject["generator"];
            GeneratorName = (string)jObject["generatorName"];
            TotalResults = ((string)jObject["totalResults"]).To<int>(0);
            StartIndex = Int32.Parse((string)jObject["startIndex"]);
            ItemsPerPage = Int32.Parse((string)jObject["itemsPerPage"]);
        }
    }
}
