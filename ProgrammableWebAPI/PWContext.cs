using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ProgrammableWebAPI
{
    public class PWContext
    {
        private string key;
        private Uri baseUri;

        public PWContext(string hostname, string key)
        {
            this.key = key;
            this.baseUri = new Uri(hostname);
        }

        public string MakeRequest(string resource, string command, string data, string item, APIRelation relation, string[] query)
        {     
            // apis
            // category                 http://api.programmableweb.com/apis/-/Mapping?apikey=123 
            // category and tags        http://api.programmableweb.com/apis/-/Enterprise/office?apikey=123
            // specific api             http://api.programmableweb.com/apis/google-maps?apikey=123
            // specific api comments    http://api.programmableweb.com/apis/google-maps/comments?apikey=123

            // mashups
            // tags                     http://api.programmableweb.com/mashups/-/photo?apikey=123
            // specific mashup          http://api.programmableweb.com/mashups/10-fascinating-googlers?apikey=123
            // specific mashup comments http://api.programmableweb.com/mashups/10-fascinating-googlers/comments&apikey=123
            // query                    http://api.programmableweb.com/mashups?q=election&apikey=123

            if (query == null) query = new string[] { };

            if (String.IsNullOrEmpty(item) && query.Count() == 0)
                throw new ArgumentException("Must request either an item or a query");
            if (!String.IsNullOrEmpty(item) && query.Count() > 1)
                throw new ArgumentException("Must request either an item or a query");

            string tags = String.Empty;
            
            if (query.Count() == 1)
                tags = query[0];
            else if (query.Count() > 1)
            {
                tags = String.Join("/", query);
            }

            StringBuilder qsBuilder = new StringBuilder();
            qsBuilder.Append(this.baseUri.ToString() + 
                resource + "/" + 
                (String.IsNullOrEmpty(item) ? "-/" : item) + // specific item
                (String.IsNullOrEmpty(tags) ? String.Empty : tags) + 
                (relation == APIRelation.None ? String.Empty : "/" + relation.ToString()) + // specifiy the relation
                "?apikey=" + this.key +
                "&alt=json");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(qsBuilder.ToString());
            //request.Credentials = new NetworkCredential(key, masterSecret);
            request.Method = command == "GET" ? "GET" : "POST";
            //request.PreAuthenticate = true; // Authentication always required, so don't wait for a 401 beforehand.
            request.Timeout = 60000; // In ms
            // Work in JSON, it's smaller and faster at the TM end. In addition, the stats resource doesn't
            // have an XML serialization available (tabular data in XML is nasty).
            //request.Accept = "application/json";
            // Set a user-agent so we can track any errors occurring a little more easily.
            request.UserAgent = "Programmable Web .NET framework wrapper";

            // Post data if it was supplied
            if (data != null && data.Length > 0)
            {
                request.ContentType = "application/json";
                request.ContentLength = data.Length;
                try
                {
                    StreamWriter req = new StreamWriter(request.GetRequestStream());
                    req.Write(data);
                    req.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            // Read the response stream and return the string value. TaguchiMail always uses UTF-8.
            string result;
            try
            {
                HttpWebResponse rep = (HttpWebResponse)request.GetResponse();
                using (StreamReader repData = new StreamReader(rep.GetResponseStream(), Encoding.UTF8))
                {
                    result = repData.ReadToEnd();
                }
                rep.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
