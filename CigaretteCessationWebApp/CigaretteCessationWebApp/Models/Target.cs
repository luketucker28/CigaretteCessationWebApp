using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CigaretteCessationWebApp.Models
{
    public class Target
    {
        public int TargetID { get; set; } 
        public string UserName {get; set;}
        public DateTime StartDate {get; set;}
        public int AmountSmoked { get; set; }
        public int ReductionGoal { get; set; }
        public virtual ICollection<Consumed> consumed { get; set; }
        public Target() {

            }
        public Target(string username, DateTime startdate, int amountsmoked, int reductiongoal)
        {
            this.UserName = username;
            this.StartDate = startdate;
            this.AmountSmoked = amountsmoked;
            this.ReductionGoal = reductiongoal;
        }
    }
}