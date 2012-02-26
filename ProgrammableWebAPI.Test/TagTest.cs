using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProgrammableWebAPI.Managers;
using ProgrammableWebAPI.Results;

namespace ProgrammableWebAPI.Test
{
    [TestFixture]
    public class TagTest : TestBase
    {
        private TagManager tagManager;

        [SetUp]
        public void SetupTest()
        {
            tagManager = new TagManager();
        }

        [Test]
        public void ListCategoriesTest()
        {
            TagResult result = tagManager.GetTags();
        }
    }
}
