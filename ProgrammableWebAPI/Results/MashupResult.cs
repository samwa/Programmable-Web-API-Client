using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Models;
using ProgrammableWebAPI.Headers;
using Newtonsoft.Json.Linq;

namespace ProgrammableWebAPI.Results
{
    public class MashupResult
    {
        public MashupHeader Header { get; set; }
        public List<Mashup> Entries { get; set; }

        public MashupResult(string json)
        {
            JObject jObject = JObject.Parse(json);

            Header = new MashupHeader(jObject);
            var apis = jObject["entries"];

            Entries = (from mashup in jObject["entries"]
                       select new Mashup((JObject)mashup)).ToList();

        }
    }
}
