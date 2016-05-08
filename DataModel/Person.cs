using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Person
    {
        public String Name { get; }

        public static Person FromJson(String json_string)
        {
            JObject json = JObject.Parse(json_string);

            if (json?["name"]?.Type == JTokenType.String)
            {
                return new Person(json["name"].ToString());
            }
            return null;
        }

        public JObject ToJson() => new JObject() { ["name"] = Name };

        public Person(string name = null)
        {
            Name = name ?? "N/A";
        }
    }
}
