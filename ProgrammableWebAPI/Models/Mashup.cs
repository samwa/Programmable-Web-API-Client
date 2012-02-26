using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ProgrammableWebAPI.Models
{
    public class Mashup : ModelBase
    {
        public List<API> Apis { get; set; }

        public Mashup(JObject jObject)
            : base(jObject)
        {

            Apis = (from api in jObject["apis"]
                       select new API((JObject)api)).ToList();
        }
    }
}
