using GMap.NET;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Route
{
    internal class RouteList
    {
        private JObject obj;

        public RouteList(JObject obj)
        {
            this.obj = obj;
        }

        public RouteList()
        {
            obj = new JObject();
            obj.Add("routes", new JArray());
        }

        public List<Route> getAllRoutes()
        {
            List<Route> routes = new List<Route>();
            JArray arr = obj["routes"] as JArray;
            foreach (JObject route in arr)
            {
                routes.Add(new Route((int)route["id"], (string)route["name"], getNodeList(route["nodes"] as JArray), (float)route["length"], (int)route["duration"]));
            }
            return routes;
        }

        public Route getRoute(int id)
        {
            JArray arr = obj["routes"] as JArray;
            foreach(JObject route in arr)
            {
                if ((int)route["id"] == id)
                {
                    return new Route(id, (string)route["name"], getNodeList(route["nodes"] as JArray), (float)route["length"], (int)route["duration"]);
                }
            }
            return null;
        }

        public void addRoute(int id, string name, List<PointLatLng> nodes, float length, int duration)
        {
            JObject route = new JObject();
            route["id"] = id;
            route["name"] = name;
            JArray arr = new JArray();
            foreach(PointLatLng node in nodes)
            {
                JObject n = new JObject();
                n.Add("latitude", node.Lat);
                n.Add("longitude", node.Lng);
                arr.Add(n);
            }
            route["nodes"] = arr;
            route["length"] = length;
            route["duration"] = duration;
            (obj["routes"] as JArray).Add(route);
        }

        public void removeRoute(int id)
        {
            JArray arr = obj["routes"] as JArray;
            foreach(JObject route in arr)
            {
                if ((int)route["id"] == id)
                {
                    arr.Remove(route);
                    break;
                }
            }
        }

        public List<PointLatLng> getNodeList(JArray arr)
        {
            List<PointLatLng> nodes = new List<PointLatLng>();
            foreach (JObject node in arr)
            {
                nodes.Add(new PointLatLng((double)node["latitude"], (double)node["longitude"]));
            }
            return nodes;
        }

        public int getRouteCount()
        {
            return (obj["routes"] as JArray).Count();
        }

        public JObject getJSONContent()
        {
            return obj;
        }
    }
}
