using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Models;
using ProgrammableWebAPI.Results;
using Newtonsoft.Json;

namespace ProgrammableWebAPI.Managers
{
    public class APIManager
    {
        protected string resource = "apis";
        protected PWContext context;

        public string Category { get; set; }
        public List<string> Tags { get; set; }

        public APIManager(PWContext context)
        {
            this.context = context;
        }

        //http://api.programmableweb.com/apis/-/Mapping?apikey=123
        public APIResult GetApis(string apiCategory, string[] apiTags)
        {
            string[] query = new string[] { apiCategory };
            query = query.Concat(apiTags).ToArray();
            string data = context.MakeRequest(this.resource, "GET", null, null, APIRelation.None, query);

            string json = data.Replace("pwfeed =  ", String.Empty);

            APIResult result = new APIResult(json); // JsonConvert.DeserializeObject<APIResult>(json); //

            return result;
        }

        //http://api.programmableweb.com/apis/-/Mapping?apikey=123
        public APIResult GetApi(string api)
        {
            string data = context.MakeRequest(this.resource, "GET", null, api, APIRelation.None, null);

            string json = data.Replace("pwfeed =  ", String.Empty);

            APIResult result = new APIResult(json); // JsonConvert.DeserializeObject<APIResult>(json); //

            return result;
        }

        //http://api.programmableweb.com/apis/-/Mapping?apikey=123
        public APIResult GetApi(string api, APIRelation relation)
        {
            string data = context.MakeRequest(this.resource, "GET", null, api, relation, null);

            string json = data.Replace("pwfeed = ", String.Empty);

            APIResult result = new APIResult(json); // JsonConvert.DeserializeObject<APIResult>(json); //

            return result;
        }

    }

}
