using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Project
{
    internal class CurrentStorage
    {
        private static FileStorage storage = new FileStorage();

        public static FileStorage get() { return storage; }

        public static void set(FileStorage newStorage)
        {
            storage = newStorage;
        }
    }
}
