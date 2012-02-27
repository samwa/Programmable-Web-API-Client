using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ProgrammableWebAPI.ConfigHandlers
{
    public class PWWebAPIConfigurationSection : ConfigurationSection
    {

        // Create a "hostname" element.
        [ConfigurationProperty("hostname")]
        public HostNameElement HostName
        {
            get
            {
                return (HostNameElement)this["hostname"];
            }
            set
            { this["hostname"] = value; }
        }

        // Create a "key" element.
        [ConfigurationProperty("key")]
        public KeyElement Key
        {
            get
            {
                return (KeyElement)this["key"];
            }
            set
            { this["key"] = value; }
        }
    }

    public class HostNameElement : ConfigurationElement
    {
        [ConfigurationProperty("value", DefaultValue = "test", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{};'\"|\\", MinLength = 2, MaxLength = 600)]
        public String Value
        {
            get
            {
                return (String)this["value"];
            }
            set
            {
                this["value"] = value;
            }
        }


    }

    public class KeyElement : ConfigurationElement
    {
        [ConfigurationProperty("value", DefaultValue = "XXXX", IsRequired = true)]
        [StringValidator(InvalidCharacters = "'\"\\", MinLength = 1, MaxLength = 60)]
        public String Value
        {
            get
            {
                return (String)this["value"];
            }
            set
            {
                this["value"] = value;
            }
        }
    }
}
