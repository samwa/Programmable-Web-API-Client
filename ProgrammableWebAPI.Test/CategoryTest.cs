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
    public class CategoryTest : TestBase
    {
        private CatagoryManager categoryManager;

        [SetUp]
        public void SetupTest()
        {
            categoryManager = new CatagoryManager();
        }

        [Test]
        public void ListCategoriesTest()
        {
            CategoryResult result = categoryManager.GetCategories();
        }
    }
}
