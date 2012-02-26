using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Results;

namespace ProgrammableWebAPI.Managers
{
    public class MashupManager
    {
        protected PWContext context;

        public MashupManager(PWContext context)
        {
            this.context = context;
        }

        public MashupResult GetMashups(string apiCategory, string[] apiTags)
        {
            return new MashupResult("");
        }
    }
}
