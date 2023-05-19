using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Util
{
    internal class CalendarDate
    {
        private int day;
        private int month;
        private int year;

        public CalendarDate()
        {
            CalendarDate tmp = new CalendarDate(DateTime.Now);
            day = tmp.day;
            month = tmp.month;
            year = tmp.year;
        }

        public CalendarDate(int day, int month, int year)
        {
            this.year = year;
            this.month = month;
            int dmax = DateTime.DaysInMonth(year, month);

            if(day <= dmax)
            {
                this.day = day;
            } 
            else
            {
                this.day = dmax;
            }
        }

        public CalendarDate(DateTime cal)
        {
            year = cal.Year;
            month = cal.Month;
            day = cal.Day;
        }

        public CalendarDate(string date)
        {
            string[] split = date.Split('/');
            day = int.Parse(split[0]);
            month = int.Parse(split[1]);
            year = int.Parse(split[2]);
        }

        public DateTime toDateTime()
        {
            return new DateTime(year, month, day);
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

    }
}
