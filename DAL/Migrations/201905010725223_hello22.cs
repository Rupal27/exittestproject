namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello22 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing");
            DropPrimaryKey("dbo.HouseListing");
            DropPrimaryKey("dbo.PopulationRegistration");
            DropPrimaryKey("dbo.UserRequestStatus");
            AlterColumn("dbo.HouseListing", "HouseListingID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PopulationRegistration", "PopulationRegistrationID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserRequestStatus", "UserRequestStatusID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.HouseListing", "HouseListingID");
            AddPrimaryKey("dbo.PopulationRegistration", "PopulationRegistrationID");
            AddPrimaryKey("dbo.UserRequestStatus", "UserRequestStatusID");
            AddForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing", "HouseListingID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing");
            DropPrimaryKey("dbo.UserRequestStatus");
            DropPrimaryKey("dbo.PopulationRegistration");
            DropPrimaryKey("dbo.HouseListing");
            AlterColumn("dbo.UserRequestStatus", "UserRequestStatusID", c => c.Int(nullable: false));
            AlterColumn("dbo.PopulationRegistration", "PopulationRegistrationID", c => c.Int(nullable: false));
            AlterColumn("dbo.HouseListing", "HouseListingID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.UserRequestStatus", "UserRequestStatusID");
            AddPrimaryKey("dbo.PopulationRegistration", "PopulationRegistrationID");
            AddPrimaryKey("dbo.HouseListing", "HouseListingID");
            AddForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing", "HouseListingID", cascadeDelete: true);
        }
    }
}
