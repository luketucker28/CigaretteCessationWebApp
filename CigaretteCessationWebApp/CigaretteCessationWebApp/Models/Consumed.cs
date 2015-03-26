using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CigaretteCessationWebApp.Models
{
    public class Consumed
    {   public int ConsumedID {get; set;}
    public string UserID { get; set; }
         [Column(TypeName = "datetime4")]
    public DateTime Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Reason { get; set; }
        public string EventPreceding { get; set; }
        public virtual Target target { get; set; }

        public Consumed()
        {

        }
        public Consumed(string userid, DateTime date, string time, string location, string reason, string eventpreceding)
        {
            this.UserID = userid;
            this.Date = Date;
            this.Time = time;
            this.Location = location;
            this.Reason = reason;
            this.EventPreceding = eventpreceding;
            
        }
    }
  
}