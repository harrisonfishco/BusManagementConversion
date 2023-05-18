using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Route
{
    internal class Route
    {
        private int id;
        private string name;
        private List<PointLatLng> nodes;
        private float length;
        private int duration;

        public Route(int id, string name, List<PointLatLng> nodes, float length, int duration)
        {
            this.id = id;
            this.name = name;
            this.nodes = nodes;
            this.length = length;
            this.duration = duration;
        }

        public string getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public List<PointLatLng> getNodes()
        {
            return nodes;
        }

        public float getLength() 
        { 
            return length;
        }

        public int getDuration()
        {
            return duration;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Route)) return false;
            return id == ((Route)obj).id && length == ((Route)obj).length;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
