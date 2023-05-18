using GMap.NET;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoranda.Util
{
    internal static class GraphHopper
    {
        public static List<PointLatLng> calculateRoute(PointLatLng start, PointLatLng end, TextBox distance, TextBox duration)
        {
            WebClient client = new WebClient();
            string url = "https://graphhopper.com/api/1/route?point="
                + start.Lat + "," + start.Lng + "&point=" + end.Lat + "," + end.Lng
                + "&profile=car&points_encoded=false&instructions=false&key=" + Constants.GRAPHHOPPER_API_KEY;
            string response = client.DownloadString(url);

            JObject json = JObject.Parse(response);

            if(json != null )
            {
                if(json.ContainsKey("message"))
                {
                    return null;
                } else
                {
                    List<PointLatLng> route = new List<PointLatLng>();
                    JObject path = (json.GetValue("paths") as JArray).ElementAt(0) as JObject;
                    duration.Text = msToMin(path.Value<int>("time")).ToString();
                    distance.Text = metersToMiles(path.Value<double>("distance")).ToString();
                    JArray points = path.Value<JObject>("points").Value<JArray>("coordinates");
                    for(int i = 0; i < points.Count; ++i)
                    {
                        JArray ar = points.Value<JArray>(i);
                        route.Add(new PointLatLng(ar.Value<double>(1), ar.Value<double>(0)));
                    }
                    return route;
                }
            }
            return null;
        }

        public static int msToMin(int time)
        {
            return (time / 1000) / 60;
        }

        public static double metersToMiles(double distance)
        {
            return distance * 0.00062137119;
        }
    }
}
