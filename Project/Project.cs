using Memoranda.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoranda.Project
{
    internal class Project
    {
        private JObject obj = null;

        public Project(JObject obj)
        {
            this.obj = obj;
        }

        public string getID()
        {
            return (string)obj["id"];
        }

        public string getTitle()
        {
            return obj.ContainsKey("title") ? (string)obj["title"] : "";
        }

        public string getDescription()
        {
            return obj.ContainsKey("description") ? (string)obj["description"] : "";
        }

        public void setTitle(string title)
        {
            obj["title"] = title;
        }

        public void setDescription(string description)
        {
            obj["description"] = description;
        }

        public CalendarDate getStartDate()
        {
            return obj.ContainsKey("startDate") ? new CalendarDate((string)obj["startDate"]) : null;
        }

        public void setStartDate(CalendarDate startDate)
        {
            if(startDate != null)
            {
                obj["startDate"] = startDate.ToString();
            }
        }

        public CalendarDate getEndDate()
        {
            return obj.ContainsKey("endDate") ? new CalendarDate((string)obj["endDate"]) : null;
        }

        public void setEndDate(CalendarDate endDate)
        {
            if(endDate != null)
            {
                obj["endDate"] = endDate.ToString();
            }
            else if(obj.ContainsKey("endDate"))
            {
                obj.Remove("endDate");
            }
        } 
    }
}
