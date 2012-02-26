using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Headers;
using Newtonsoft.Json.Linq;
using ProgrammableWebAPI.Models;

namespace ProgrammableWebAPI.Results
{
    public class APIResult
    {
        public APIHeader Header { get; set; }
        public List<API> Entries { get; set; }

        public APIResult(string json)
        {
            JObject jObject = JObject.Parse(json);

            Header = new APIHeader(jObject);
            var apis = jObject["entries"];

            Entries = (from api in jObject["entries"]
                       select new API((JObject)api)).ToList();

        }
    }
}
