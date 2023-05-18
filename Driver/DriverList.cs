using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Driver
{
    internal class DriverList
    {
        private JObject obj;

        public DriverList(JObject obj)
        {
            this.obj = obj;
        }

        public DriverList()
        {
            obj = new JObject();
            obj.Add("drivers", new JArray());
        }

        public List<Driver> GetAllDrivers()
        {
            List<Driver> list = new List<Driver>();
            JArray arr = obj["drivers"] as JArray;
            foreach (JObject driver in arr)
            {
                list.Add(new Driver((int)driver["id"], (string)driver["name"], (string)driver["phone"]));
            }
            return list;
        }

        public Driver getDriver(int id)
        {
            JArray arr = obj["drivers"] as JArray;
            foreach (JObject driver in arr)
            {
                if ((int)driver["id"] == id)
                {
                    return new Driver(id, (string)driver["name"], (string)driver["phone"]);
                }
            }
            return null;
        }

        public void addDriver(int id, string name, string phone)
        {
            JObject driver = new JObject();
            driver["id"] = id;
            driver["name"] = name;
            driver["phone"] = phone;
            (obj["drivers"] as JArray).Add(driver);
        }

        public void removeDriver(int id)
        {
            JArray arr = obj["drivers"] as JArray;
            foreach(JObject driver in arr)
            {
                if ((int)driver["id"] == id)
                {
                    arr.Remove(driver);
                    break;
                }
            }
        }

        public int getDriverCount()
        {
            return (obj["drivers"] as JArray).Count();
        }

        public JObject getJSONContent()
        {
            return obj;
        }
    }
}
