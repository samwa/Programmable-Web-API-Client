using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

using ProgrammableWebAPI.Extensions;
using Newtonsoft.Json;

namespace ProgrammableWebAPI.Models
{
    public class API : ModelBase, IAPI
    {
        public string Package { get; set; }
        public string Favicon { get; set; }
        public string DownloadUrl { get; set; }
        public string RemoteFeed { get; set; }
        public string Category { get; set; }
        public string Protocols { get; set; }
        public string ServiceEndpoints { get; set; }
        public string Version { get; set; }
        public string Wsdl { get; set; }
        public string DataFormats { get; set; }
        public string Apigroups { get; set; }
        public string Example { get; set; }
        public string ClientInstall { get; set; }
        public string Authentication { get; set; }
        public string Ssl { get; set; }
        public bool Readonly { get; set; }
        public string VendorApiKits { get; set; }
        public string CommunityApiKits { get; set; }
        public string Blog { get; set; }
        public string Forum { get; set; }
        public string Support { get; set; }
        public string AccountReq { get; set; }
        public string Commercial { get; set; }
        public string Provider { get; set; }
        public string ManagedBy { get; set; }
        public string NonCommercial { get; set; }
        public string DataLicensing { get; set; }
        public string Fees { get; set; }
        public string Limits { get; set; }
        public string Terms { get; set; }
        public string Company { get; set; }

        public API()
            : base()
        {

        }

        public API(JObject jObject)
            : base(jObject)
        {
            Package = (string)jObject["package"];
            Favicon = (string)jObject["favicon"];
            DownloadUrl = (string)jObject["downloadUrl"];
            RemoteFeed = (string)jObject["remoteFeed"];
            CommentUrl = (string)jObject["commentUrl"];
            Category = (string)jObject["category"];
            Protocols = (string)jObject["protocols"];
            ServiceEndpoints = (string)jObject["serviceEndpoints"];
            Version = (string)jObject["version"];
            Wsdl = (string)jObject["wsdl"];
            DataFormats = (string)jObject["dataFormats"];
            Apigroups = (string)jObject["apigroups"];
            Example = (string)jObject["example"];
            ClientInstall = (string)jObject["clientInstall"];
            Authentication = (string)jObject["authentication"];
            Ssl = (string)jObject["ssl"];
            Readonly = ((string)jObject["readonly"]).To<bool>(false);
            VendorApiKits = (string)jObject["VendorApiKits"];
            CommunityApiKits = (string)jObject["CommunityApiKits"];
            Blog = (string)jObject["blog"];
            Forum = (string)jObject["forum"];
            Support = (string)jObject["support"];
            AccountReq = (string)jObject["accountReq"];
            Commercial = (string)jObject["commercial"];
            Provider = (string)jObject["provider"];
            ManagedBy = (string)jObject["managedBy"];
            NonCommercial = (string)jObject["nonCommercial"];
            DataLicensing = (string)jObject["dataLicensing"];
            Fees = (string)jObject["fees"];
            Limits = (string)jObject["limits"];
            Terms = (string)jObject["terms"];
            Company = (string)jObject["company"];
        }
    }
}
