using Memoranda.Bus;
using Memoranda.Driver;
using Memoranda.Route;
using Memoranda.Tour;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Project
{
    internal class FileStorage
    {
        private static string path = Util.Util.getEnvDir();

        public FileStorage()
        {
            Console.WriteLine("[DEBUG]***Storage path has been set to " + path);
        }

        public static void saveDocument(JObject obj, string filePath, string root)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    if(obj == null)
                    {
                        obj = new JObject(new JProperty(root, new JArray()));
                    }

                    writer.Write(obj.ToString());
                }
            } catch (Exception e)
            {
                throw new Exception("Failed to save a document to " + filePath, e);
            }
        }

        public static JObject openDocument(Stream inputStream, string root)
        {
            using(StreamReader reader = new StreamReader(inputStream))
            {
                try
                {
                    using(JsonReader jsonReader = new JsonTextReader(reader))
                    {
                        return JObject.Load(jsonReader);
                    }
                } catch(Exception e) when (e is Newtonsoft.Json.JsonException || e is IOException)
                {
                    JObject obj = new JObject();
                    JArray array = new JArray();
                    obj.Add(root, array);
                    return obj;
                }
            }
        }

        public static JObject openDocument(string filePath, string root)
        {
            try
            {
                using(FileStream fileStream = File.OpenRead(filePath))
                {
                    return openDocument(fileStream, root);
                }
            } catch(Exception e)
            {
                throw new Exception("Failed to read a document from " + filePath, e);
            }
        }

        public static bool documentExists(string filePath) { return File.Exists(filePath); }

        public void createProjectStorage(Project proj)
        {
            Directory.CreateDirectory(path + proj.getID());
        }

        public void removeProjectStorage(Project proj)
        {
            string id = proj.getID();
            Directory.Delete(path + id, true);
        }

        public void openProjectManager()
        {
            if(!File.Exists(path + ".projects"))
            {
                ProjectManager.obj = null;
                return;
            }

            ProjectManager.obj = openDocument(path + ".projects", "project-list");
        }

        public void storeProjectManager()
        {
            saveDocument(ProjectManager.obj, path + ".projects", "project-list");
        }

        public BusList openBusList(Project proj)
        {
            string fn = path + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".buses";
            if(documentExists(fn))
            {
                return new BusList(openDocument(fn, "buses"));
            }
            else
            {
                return new BusList();
            }
        }

        public void storeBusList(BusList bl, Project proj)
        {
            saveDocument(bl.getJSONContent(), path + Path.DirectorySeparatorChar.ToString() + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".buses", "buses");
        }

        public DriverList openDriverList(Project proj)
        {
            string fn = path + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".drivers";
            if(documentExists(fn))
            {
                return new DriverList(openDocument(fn, "drivers"));
            }
            else
            {
                return new DriverList();
            }
        }

        public void storeDriverList(DriverList dl, Project proj)
        {
            saveDocument(dl.getJSONContent(), path + Path.DirectorySeparatorChar.ToString() + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".drivers", "drivers");
        }

        public RouteList openRouteList(Project proj)
        {
            string fn = path + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".routes";
            if(documentExists(fn))
            {
                return new RouteList(openDocument(fn, "routes"));
            }
            else
            {
                return new RouteList();
            }
        }

        public void storeRouteList(RouteList rl, Project proj)
        {
            saveDocument(rl.getJSONContent(), path + Path.DirectorySeparatorChar.ToString() + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".routes", "routes");
        }

        public TourList openTourList(Project proj)
        {
            string fn = path + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".tours";
            if(documentExists(fn))
            {
                return new TourList(openDocument(fn, "tours"));
            }
            else
            {
                return new TourList();
            }
        }

        public void storeTourList(TourList tl, Project proj)
        {
            saveDocument(tl.getJSONContent(), path + Path.DirectorySeparatorChar.ToString() + proj.getID() + Path.DirectorySeparatorChar.ToString() + ".tours", "tours");
        }
    }
}
