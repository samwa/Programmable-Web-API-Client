using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

using ProgrammableWebAPI.Extensions;
using Newtonsoft.Json;

namespace ProgrammableWebAPI.Models
{
    public class ModelBase : IModelBase
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Self { get; set; }
        public string Summary { get; set; }
        public decimal Rating { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Downloads { get; set; }
        public int UseCount { get; set; }
        public string Icon { get; set; }
        public string SampleUrl { get; set; }
        public DateTime DateModified { get; set; }
        public int NumComments { get; set; }
        public string CommentUrl { get; set; }
        public List<string> Tags { get; set; }
        public DateTime Updated { get; set; }

        public ModelBase()
        {

        }

        public ModelBase(JObject jObject)
        {
            Id = (string)jObject["id"];
            Title = (string)jObject["title"];
            Link = (string)jObject["link"];
            Self = (string)jObject["self"];
            Summary = (string)jObject["summary"];
            Rating = ((string)jObject["rating"]).To<decimal>(0m);
            Name = (string)jObject["name"];
            Label = (string)jObject["label"];
            Author = (string)jObject["author"];
            Description = (string)jObject["description"];
            Type = ((string)jObject["type"]).To<int>(0);
            Downloads = ((string)jObject["downloads"]).To<int>(0);
            UseCount = ((string)jObject["useCount"]).To<int>(0);
            Icon = (string)jObject["icon"];
            SampleUrl = (string)jObject["sampleUrl"];
            DateModified = ((string)jObject["dateModified"]).To<DateTime>(DateTime.Now);
            NumComments = ((string)jObject["numComments"]).To<int>(0);
            Tags = JsonConvert.DeserializeObject<List<string>>(((JArray)jObject["tags"]).ToString());
            Updated = ((string)jObject["updated"]).To<DateTime>(DateTime.Now);
        }
     
    }
}
