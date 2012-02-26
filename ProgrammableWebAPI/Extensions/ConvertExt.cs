using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammableWebAPI.Extensions
{
    public static class ConvertExt
    {
        //public static int ToInt32(this Convert c, string value, int defaultVal)
        //{
        //    int returnVal = 0;
        //    if (!Int32.TryParse(value, out returnVal))
        //    {
        //        returnVal = defaultVal;
        //    }

        //    return returnVal;
        //}

        //public static bool ToBoolean(this Convert c, string value, bool defaultVal)
        //{
        //    bool returnVal = false;
        //    if (!Boolean.TryParse(value, out returnVal))
        //    {
        //        returnVal = defaultVal;
        //    }

        //    return returnVal;
        //}

        // generic convert extension method
        public static T To<T>(this object input, T defaultValue) where T : IConvertible
        {
            string type = typeof(T).Name;

            TypeCode typecode;
            if (!Enum.TryParse(type, out typecode)) throw new ArgumentException("Could not convert!");

            try
            {
                return (T)Convert.ChangeType(input, typecode);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
