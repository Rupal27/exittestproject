namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdfds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HouseListing", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.HouseListing", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.PopulationRegistration", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.PopulationRegistration", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Member", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Member", "ModifiedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserRequestStatus", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserRequestStatus", "ModifiedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRequestStatus", "ModifiedOn");
            DropColumn("dbo.UserRequestStatus", "CreatedOn");
            DropColumn("dbo.Member", "ModifiedOn");
            DropColumn("dbo.Member", "CreatedOn");
            DropColumn("dbo.PopulationRegistration", "ModifiedOn");
            DropColumn("dbo.PopulationRegistration", "CreatedOn");
            DropColumn("dbo.HouseListing", "ModifiedOn");
            DropColumn("dbo.HouseListing", "CreatedOn");
        }
    }
}
