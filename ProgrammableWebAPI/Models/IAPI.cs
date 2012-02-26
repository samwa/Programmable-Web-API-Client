using System;
namespace ProgrammableWebAPI.Models
{
    public interface IAPI : IModelBase
    {
        string AccountReq { get; set; }
        string Apigroups { get; set; }
        string Authentication { get; set; }
        string Blog { get; set; }
        string Category { get; set; }
        string ClientInstall { get; set; }
        string Commercial { get; set; }
        string CommunityApiKits { get; set; }
        string Company { get; set; }
        string DataFormats { get; set; }
        string DataLicensing { get; set; }
        string DownloadUrl { get; set; }
        string Example { get; set; }
        string Favicon { get; set; }
        string Fees { get; set; }
        string Forum { get; set; }
        string Limits { get; set; }
        string ManagedBy { get; set; }
        string NonCommercial { get; set; }
        string Package { get; set; }
        string Protocols { get; set; }
        string Provider { get; set; }
        bool Readonly { get; set; }
        string RemoteFeed { get; set; }
        string ServiceEndpoints { get; set; }
        string Ssl { get; set; }
        string Support { get; set; }
        string Terms { get; set; }
        string VendorApiKits { get; set; }
        string Version { get; set; }
        string Wsdl { get; set; }
    }
}
