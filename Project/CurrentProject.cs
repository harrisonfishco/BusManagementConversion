using Memoranda.Bus;
using Memoranda.Driver;
using Memoranda.Route;
using Memoranda.Tour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Project
{
    internal class CurrentProject
    {
        private static Project project;
        private static TourList tourList;
        private static RouteList routeList;
        private static DriverList driverList;
        private static BusList busList;

        static CurrentProject()
        {
            string prjId = null;//NEED TO ADD CONTEXT FOR LAST USED PROJECT
            if(prjId == null) {
                prjId = "__default";
            }
            project = ProjectManager.getProject(prjId);

            if(project == null)
            {
                project = ProjectManager.getProject("__defualt");
                if(project == null)
                {
                    if(ProjectManager.getActiveProjects().Count() == 0)
                    {
                        project = ProjectManager.createProject("__default", "Default Project", new Util.CalendarDate(), null);
                    }
                    else
                    {
                        project = (Project)ProjectManager.getActiveProjects().First();
                    }
                }
            }

            tourList = CurrentStorage.get().openTourList(project);
            routeList = CurrentStorage.get().openRouteList(project);
            driverList = CurrentStorage.get().openDriverList(project);
            busList = CurrentStorage.get().openBusList(project);
        }

        public static Project get()
        {
            return project;
        }

        public static TourList getTourList()
        {
            return tourList;
        }

        public static RouteList getRouteList()
        {
            return routeList;
        }

        public static DriverList GetDriverList()
        {
            return driverList;
        }

        public static BusList getBusList()
        {
            return busList;
        }

        public static void set(Project newProject)
        {
            if (project.getID() == newProject.getID()) return;
            tourList = CurrentStorage.get().openTourList(newProject);
            routeList = CurrentStorage.get().openRouteList(newProject);
            driverList = CurrentStorage.get().openDriverList(newProject);
            busList = CurrentStorage.get().openBusList(newProject);
        }

        public static void save()
        {
            FileStorage storage = CurrentStorage.get();

            storage.storeTourList(tourList, project);
            storage.storeRouteList(routeList, project);
            storage.storeDriverList(driverList, project);
            storage.storeBusList(busList, project);

            storage.storeProjectManager();
        }
    }
}
