using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Configuration;
using ProgrammableWebAPI.Managers;
using ProgrammableWebAPI.Models;
using ProgrammableWebAPI.Results;

namespace ProgrammableWebAPI.Test
{
    [TestFixture]
    public class APITest : TestBase
    {
        private APIManager apiManager;

        [SetUp]
        public void SetupTest()
        {
            base.SetupTest();
            apiManager = new APIManager(context);
        }

        [Test]
        //http://api.programmableweb.com/apis?apikey=1234567890abcdef6019276547624973
        public void ListAPIsTest()
        {
            APIResult result = apiManager.GetApis("Mapping", new string[]{"display"});
        }

        [Test]
        //http://api.programmableweb.com/apis?apikey=1234567890abcdef6019276547624973
        public void ListAPIsWithTagsTest()
        {
            APIResult result = apiManager.GetApis("Mapping", new string[] { "display", "places", "viewer" });
        }

        [Test]
        //http://api.programmableweb.com/apis/Hoptoad?apikey=1234567890abcdef6019276547624973
        public void LoadAPITest()
        {
            APIResult result = apiManager.GetApi("google-maps");
        }

        [Test]
        //http://api.programmableweb.com/apis/Hoptoad?apikey=1234567890abcdef6019276547624973
        public void ListAPIMashups()
        {
            APIResult result = apiManager.GetApi("google-maps", APIRelation.Mashups);
        }

        [Test]
        //http://api.programmableweb.com/apis/Hoptoad?apikey=1234567890abcdef6019276547624973
        public void ListAPIComments()
        {
            APIResult result = apiManager.GetApi("google-maps", APIRelation.Comments);
        }
    }
}
