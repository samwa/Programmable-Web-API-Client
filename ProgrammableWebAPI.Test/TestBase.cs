using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Configuration;
using ProgrammableWebAPI.Managers;

namespace ProgrammableWebAPI.Test
{
    public class TestBase
    {
        internal PWContext context;
        private static string hostName = ConfigurationManager.AppSettings["ProgrammableWeb.HostName"];
        private static string key = ConfigurationManager.AppSettings["ProgrammableWeb.Key"];

        [SetUp]
        public void SetupTest()
        {
            context = new PWContext(hostName, key);
        }
    }
}
