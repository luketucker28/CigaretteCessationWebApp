namespace CigaretteCessationWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consumeds",
                c => new
                    {
                        ConsumedID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Time = c.String(),
                        Location = c.String(),
                        Reason = c.String(),
                        EventPreceding = c.String(),
                        target_TargetID = c.Int(),
                    })
                .PrimaryKey(t => t.ConsumedID)
                .ForeignKey("dbo.Targets", t => t.target_TargetID)
                .Index(t => t.target_TargetID);
            
            CreateTable(
                "dbo.Targets",
                c => new
                    {
                        TargetID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        AmountSmoked = c.Int(nullable: false),
                        ReductionGoal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TargetID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consumeds", "target_TargetID", "dbo.Targets");
            DropIndex("dbo.Consumeds", new[] { "target_TargetID" });
            DropTable("dbo.Targets");
            DropTable("dbo.Consumeds");
        }
    }
}