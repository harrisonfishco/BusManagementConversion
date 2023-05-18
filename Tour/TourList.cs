using Memoranda.Project;
using Memoranda.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Tour
{
    internal class TourList
    {
        private JObject obj;

        public TourList(JObject obj)
        {
            this.obj = obj;
        }

        public TourList()
        {
            obj = new JObject();
            obj.Add("tours", new JArray());
        }

        public List<Tour> getAllTours()
        {
            List<Tour> list = new List<Tour>();
            JArray tours = obj["tours"] as JArray;
            foreach(JObject tour in tours)
            {
                Driver.Driver d = CurrentProject.GetDriverList().getDriver((int)tour["driverID"]);
                Bus.Bus b = CurrentProject.getBusList().getBus((int)tour["busID"]);
                Route.Route r = CurrentProject.getRouteList().getRoute((int)tour["routeID"]);
                CalendarDate startDate = new CalendarDate((string)tour["startDate"]);
                TimeSpan startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)tour["startHour"], (int)tour["startMinute"], 0) 
                    - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                list.Add(new Tour((int)tour["id"], startDate, startTime, d, b, r));
            }
            return list;
        }

        public List<Tour> getAllToursAt(CalendarDate date)
        {
            //todo
            return new List<Tour>();
        }

        public Tour getTour(int id)
        {
            JArray arr = obj["tours"] as JArray;
            foreach(JObject tour in arr)
            {
                if ((int)tour["id"] == id)
                {
                    Driver.Driver d = CurrentProject.GetDriverList().getDriver((int)tour["driverID"]);
                    Bus.Bus b = CurrentProject.getBusList().getBus((int)tour["busID"]);
                    Route.Route r = CurrentProject.getRouteList().getRoute((int)tour["routeID"]);
                    CalendarDate startDate = new CalendarDate((string)tour["startDate"]);
                    TimeSpan startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)tour["startHour"], (int)tour["startMinute"], 0)
                        - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    return new Tour((int)tour["id"], startDate, startTime, d, b, r);
                }
            }
            return null;
        }

        public void addTour(int id, CalendarDate startDate, TimeSpan startTime, Driver.Driver d, Bus.Bus b, Route.Route r)
        {
            JObject tour = new JObject();
            tour["id"] = id;
            tour["startDate"] = startDate.ToString();
            tour["startHour"] = startTime.Hours;
            tour["startMinute"] = startTime.Minutes;
            tour["driverID"] = d.getID();
            tour["busID"] = b.getId();
            tour["routeID"] = r.getId();
            (obj["tours"] as JArray).Add(tour);
        }

        public void removeTour(int id)
        {
            JArray tours = obj["tours"] as JArray;
            foreach(JObject tour in tours)
            {
                if ((int)tour["id"] == id)
                {
                    tours.Remove(tour);
                    break;
                }
            }
        }

        public int getTourCount()
        {
            return (obj["tours"] as JArray).Count;
        }

        public JObject getJSONContent()
        {
            return obj;
        }
    }
}
