﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ProgrammableWebAPI.Headers
{
    public class MashupHeader : HeaderBase
    {
        public MashupHeader(JObject jObject)
            : base(jObject)
        { }
    }
}
