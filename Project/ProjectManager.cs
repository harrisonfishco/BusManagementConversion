using Memoranda.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Project
{
    internal class ProjectManager
    {
        public static JObject obj = null;

        static ProjectManager()
        {
            init();
        }

        public static void init()
        {
            CurrentStorage.get().openProjectManager();
            if(obj == null)
            {
                obj = new JObject();
                obj.Add("project-list", new JArray());

                createProject("__default", "Default project", new Util.CalendarDate(), null);
            }
        }

        public static Project getProject(string id)
        {
            JArray arr = obj["project-list"] as JArray;
            foreach(JObject item in arr)
            {
                if ((string)item["id"] == id)
                {
                    return new Project(item);
                }
            }
            return null;
        }

        public static List<Project> getAllProjects()
        {
            JArray arr = obj["project-list"] as JArray;
            List<Project> list = new List<Project>();
            foreach(JObject item in arr)
            {
                list.Add(new Project(item));
            }
            return list;
        }

        public static int getAllProjectsNumber()
        {
            int i;
            try
            {
                i = (obj["project-list"] as JArray).Count;
            } 
            catch(Exception e)
            {
                i = 1;
            }
            return i;
        }

        public static List<Project> getActiveProjects()
        {
            //todo: This needs to be implemented
            return null;
        }

        public static int getActiveProjectNumber()
        {
            //todo: this needs to be implemented
            return 0;
        }

        public static Project createProject(string id, string title, Util.CalendarDate startDate, Util.CalendarDate endDate)
        {
            JObject ob = new JObject();
            ob["id"] = id;
            (obj["project-list"] as JArray).Add(ob);
            Project proj = new Project(ob);
            proj.setTitle(title);
            proj.setStartDate(startDate);
            proj.setEndDate(endDate);
            CurrentStorage.get().createProjectStorage(proj);
            return proj;
        }

        public static Project createProject(string title, CalendarDate startDate, CalendarDate endDate)
        {
            return createProject(Util.Util.generateId(), title, startDate, endDate);
        }

        public static void removeProject(String id)
        {
            Project proj = getProject(id);
            if(proj == null)
            {
                return;
            }
            CurrentStorage.get().removeProjectStorage(proj);
            JArray arr = obj["project-list"] as JArray;
            foreach(JObject o in arr)
            {
                if ((string)o["id"] == id)
                {
                    arr.Remove(o);
                    return;
                }
            }
        }
    }
}
