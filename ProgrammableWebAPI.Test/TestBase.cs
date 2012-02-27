using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Configuration;
using ProgrammableWebAPI.Managers;
using ProgrammableWebAPI.ConfigHandlers;

namespace ProgrammableWebAPI.Test
{
    public class TestBase
    {
        internal PWContext context;
        PWWebAPIConfigurationSection config = (PWWebAPIConfigurationSection)ConfigurationManager.GetSection("PWAPIGroup/PWAPI");

        private static string hostName;
        private static string key;

        [SetUp]
        public void SetupTest()
        {
            hostName = config.HostName.Value;
            key = config.Key.Value;

            context = new PWContext(hostName, key);
        }
    }
}
