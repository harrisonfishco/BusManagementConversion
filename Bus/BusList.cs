using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Memoranda.Bus
{
    internal class BusList
    {
        private JObject obj = null;

        public BusList(JObject obj)
        {
            this.obj = obj;
        }

        public BusList()
        {
            obj = new JObject();
            obj.Add("buses", new JArray());
        }

        public List<Bus> getAllBuses()
        {
            List<Bus> busList = new List<Bus>();
            JArray arr = obj["buses"] as JArray;
            foreach (JObject o in arr)
            {
                int id = o.Value<int>("id");
                int seats = o.Value<int>("seats");
                busList.Add(new Bus(id, seats));
            }
            return busList;
        }

        public Bus getBus(int id)
        {
            JArray arr = obj["buses"] as JArray;
            foreach(JObject o in arr)
            {
                if(o.Value<int>("id") == id)
                {
                    return new Bus(id, o.Value<int>("seats"));
                }
            }
            return null;
        }

        public void addBus(int id, int seats)
        {
            JObject bus = new JObject();
            bus["id"] = id;
            bus["seats"] = seats;
            JArray arr = obj["buses"] as JArray;
            arr.Add(bus);
        }

        public void removeBus(int id)
        {
            JArray arr = obj["buses"] as JArray;
            for(int i = 0; i < arr.Count; ++i)
            {
                JObject bus = arr[i] as JObject;
                if(bus.Value<int>("id") == id)
                {
                    arr.RemoveAt(i);
                    break;
                }
            }
        }

        public int getBusCount()
        {
            return (obj["buses"] as JArray).Count;
        }

        public JObject getJSONContent()
        {
            return obj;
        }
    }
}
