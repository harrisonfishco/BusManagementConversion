using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Bus
{
    internal class Bus
    {
        private int id;
        private int seats;

        public Bus(int id, int seats)
        {
            this.id = id;
            this.seats = seats;
        }

        public int getId() { return id; }
        public int getSeats() {  return seats; }

        public override string ToString()
        {
            return "Bus #" + id + " seats " + seats;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Bus)) return false;
            return id == ((Bus)obj).id && seats == ((Bus)obj).seats;
        }
    }
}
