using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Route
{
    internal class Node
    {
        private double lat;
        private double lon;

        public Node(double lat, double lon)
        {
            this.lat = lat;
            this.lon = lon;
        }

        public double getLatitude()
        {
            return lat;
        }

        public double getLongitude()
        {
            return lon;
        }
    }
}
