using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Results;

namespace ProgrammableWebAPI.Managers
{
    public class CatagoryManager
    {
        public CatagoryManager()
        {

        }

        public CategoryResult GetCategories()
        {
            return new CategoryResult();
        }
    }
}
