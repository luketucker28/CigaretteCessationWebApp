using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CigaretteCessationWebApp.Models
{
    public class Consumed
    {   public int ConsumedID {get; set;}
        public string UserName {get; set;}
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Reason { get; set; }
        public string EventPreceding { get; set; }
        public virtual Target target { get; set; }

        public Consumed()
        {

        }
        public Consumed(string username, DateTime date, string time, string location, string reason, string eventpreceding)
        {
            this.UserName = username;
            this.Date = Date;
            this.Time = time;
            this.Location = location;
            this.Reason = reason;
            this.EventPreceding = eventpreceding;
            
        }
    }
  
}