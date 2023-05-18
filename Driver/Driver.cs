using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Driver
{
    internal class Driver
    {
        private int id;
        private string name;
        private string phone;

        public Driver(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        public int getID() { return id; }

        public string getName() { return name; }
        public string getPhone() { return phone; }

        public override string ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Driver)) return false;
            return id == ((Driver)obj).getID() && name == ((Driver)obj).getName() && phone == ((Driver)obj).getPhone();
        }
    }
}
