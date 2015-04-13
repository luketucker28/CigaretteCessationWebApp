namespace CigaretteCessationWebApp.Migrations
{
    using CigaretteCessationWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CigaretteCessationWebApp.CigaretteCessationContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CigaretteCessationWebApp.CigaretteCessationContext";
        }

        protected override void Seed(CigaretteCessationWebApp.CigaretteCessationContext context)
        {
            context.Targets.AddOrUpdate(i => i.StartDate,
                new Target
                {

                    StartDate = new DateTime(2014, 4, 8),
                    AmountSmoked = 15,
                    ReductionGoal = 3
                });
            context.Consumeds.AddOrUpdate(i => new { i.Date, i.Time },

                new Consumed
                {
                    UserID = "sevber",
                    Date = new DateTime(2012, 3, 5),
                    Time = "4:30 PM",
                    Location = "Home",
                    Reason = "Stress",
                    Comments = "Fight WIth Boss"

                },
                new Consumed
                {
                    UserID = "secfd",
                    Date = new DateTime(2014, 4, 30),
                    Time = "3:30 PM",
                    Location = "Home",
                    Reason = "Stress",
                    Comments = "Fight WIth Boss"

                });
        }
    }
}
