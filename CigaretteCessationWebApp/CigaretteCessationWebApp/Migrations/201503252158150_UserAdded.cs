namespace CigaretteCessationWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Consumeds", "UserID", c => c.String());
            DropColumn("dbo.Consumeds", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Consumeds", "UserName", c => c.String());
            DropColumn("dbo.Consumeds", "UserID");
        }
    }
}
