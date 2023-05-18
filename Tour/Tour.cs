using Memoranda.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Tour
{
    internal class Tour
    {
        private int id;
        private CalendarDate startDate;
        private TimeSpan startTime;

        private Driver.Driver driver;
        private Bus.Bus bus;
        private Route.Route route;

        public Tour(int id , CalendarDate startDate, TimeSpan startTime)
        {
            this.id = id;
            this.startDate = startDate;
            this.startTime = startTime;
        }

        public Tour(int id, CalendarDate startDate, TimeSpan startTime, Driver.Driver driver, Bus.Bus bus, Route.Route route)
        {
            this.id = id;
            this.startDate = startDate;
            this.startTime = startTime;
            this.driver = driver;
            this.bus = bus;
            this.route = route;
        }

        public int getID()
        {
            return id;
        }

        public CalendarDate getStartDate()
        {
            return startDate;
        }

        public TimeSpan getStartTime()
        {
            return startTime;
        }

        public void setDriver(Driver.Driver driver)
        {
            this.driver = driver;
        }

        public Driver.Driver getDriver()
        {
            return driver;
        }

        public void setBus(Bus.Bus bus)
        {
            this.bus = bus;
        }

        public Bus.Bus getBus()
        {
            return bus;
        }

        public void setRoute(Route.Route route)
        {
            this.route = route;
        }

        public Route.Route getRoute()
        {
            return route;
        }
    }
}
