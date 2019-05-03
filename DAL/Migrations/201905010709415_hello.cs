namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing");
            DropForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member");
            DropForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member");
            DropPrimaryKey("dbo.HouseListing");
            DropPrimaryKey("dbo.PopulationRegistration");
            DropPrimaryKey("dbo.Member");
            DropPrimaryKey("dbo.UserRequestStatus");
            AlterColumn("dbo.HouseListing", "HouseListingID", c => c.Int(nullable: false));
            AlterColumn("dbo.PopulationRegistration", "PopulationRegistrationID", c => c.Int(nullable: false));
            AlterColumn("dbo.Member", "MemberID", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRequestStatus", "UserRequestStatusID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.HouseListing", "HouseListingID");
            AddPrimaryKey("dbo.PopulationRegistration", "PopulationRegistrationID");
            AddPrimaryKey("dbo.Member", "MemberID");
            AddPrimaryKey("dbo.UserRequestStatus", "UserRequestStatusID");
            AddForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing", "HouseListingID", cascadeDelete: true);
            AddForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
            AddForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member");
            DropForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member");
            DropForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing");
            DropPrimaryKey("dbo.UserRequestStatus");
            DropPrimaryKey("dbo.Member");
            DropPrimaryKey("dbo.PopulationRegistration");
            DropPrimaryKey("dbo.HouseListing");
            AlterColumn("dbo.UserRequestStatus", "UserRequestStatusID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Member", "MemberID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PopulationRegistration", "PopulationRegistrationID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.HouseListing", "HouseListingID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.UserRequestStatus", "UserRequestStatusID");
            AddPrimaryKey("dbo.Member", "MemberID");
            AddPrimaryKey("dbo.PopulationRegistration", "PopulationRegistrationID");
            AddPrimaryKey("dbo.HouseListing", "HouseListingID");
            AddForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
            AddForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
            AddForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing", "HouseListingID", cascadeDelete: true);
        }
    }
}
