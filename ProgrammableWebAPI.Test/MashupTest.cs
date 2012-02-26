using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProgrammableWebAPI.Results;
using ProgrammableWebAPI.Managers;

namespace ProgrammableWebAPI.Test
{
    [TestFixture]
    public class MashupTest : TestBase
    {
        private MashupManager mashupManager;

        [SetUp]
        public void SetupTest()
        {
            base.SetupTest();
            mashupManager = new MashupManager(context);
        }

        [Test]
        //http://api.programmableweb.com/apis?apikey=1234567890abcdef6019276547624973
        public void ListMashupsTest()
        {
            MashupResult result = mashupManager.GetMashups("Mapping", new string[] { "display" });
        }
    }
}
