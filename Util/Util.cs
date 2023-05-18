using Memoranda.Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Util
{
    internal static class Util
    {
        static long seed = 0;

        public static String generateId()
        {
            long seed1;
            do
            {
                seed1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            while (seed1 == seed);

            seed = seed1;
            Random r = new Random((int)seed);
            return r.Next().ToString("X") +
                "-" + r.Next(65535).ToString("X") +
                "-" + r.Next(65535).ToString("X") +
                "-" + r.Next(65535).ToString("X");
        }

        public static string getEnvDir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + Path.DirectorySeparatorChar.ToString() + ".memoranda" + Path.DirectorySeparatorChar.ToString();
        }

        public static int generateRouteId()
        {
            Random rand = new Random();
            int id = -1;
            do
            {
                id = rand.Next(10000);
            } while (CurrentProject.getRouteList().getRoute(id) != null);
            return id;
        }
    }
}
