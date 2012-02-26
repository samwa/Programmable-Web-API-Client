using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using ProgrammableWebAPI.Models;

using ProgrammableWebAPI.Extensions;

namespace ProgrammableWebAPI.Headers
{
    public class APIHeader : HeaderBase
    {
        public APIHeader(JObject jObject)
            : base(jObject)
        { }
    }
}
