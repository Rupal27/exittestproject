namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HouseListing",
                c => new
                    {
                        HouseListingID = c.Int(nullable: false, identity: true),
                        ApartmentNumber = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        NameOfHead = c.String(nullable: false),
                        OwnershipStatus = c.Int(nullable: false),
                        NumberofRooms = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HouseListingID);
            
            CreateTable(
                "dbo.PopulationRegistration",
                c => new
                    {
                        PopulationRegistrationID = c.Int(nullable: false, identity: true),
                        RelationToHead = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        MaritalStatus = c.Int(nullable: false),
                        OccupationStatus = c.Int(nullable: false),
                        NatureOfOccupation = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        AgeAtMarriage = c.Int(nullable: false),
                        MemberID = c.Int(nullable: false),
                        HouseListingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PopulationRegistrationID)
                .ForeignKey("dbo.HouseListing", t => t.HouseListingID, cascadeDelete: true)
                .ForeignKey("dbo.Member", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID)
                .Index(t => t.HouseListingID);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        IsApprover = c.Boolean(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ProfileImage = c.String(nullable: false),
                        AadharNo = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => t.MemberID)
                .Index(t => t.Email, unique: true)
                .Index(t => t.AadharNo, unique: true);
            
            CreateTable(
                "dbo.UserRequestStatus",
                c => new
                    {
                        UserRequestStatusID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(nullable: false),
                        RequestStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserRequestStatusID)
                .ForeignKey("dbo.Member", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member");
            DropForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member");
            DropForeignKey("dbo.PopulationRegistration", "HouseListingID", "dbo.HouseListing");
            DropIndex("dbo.UserRequestStatus", new[] { "MemberID" });
            DropIndex("dbo.Member", new[] { "AadharNo" });
            DropIndex("dbo.Member", new[] { "Email" });
            DropIndex("dbo.PopulationRegistration", new[] { "HouseListingID" });
            DropIndex("dbo.PopulationRegistration", new[] { "MemberID" });
            DropTable("dbo.UserRequestStatus");
            DropTable("dbo.Member");
            DropTable("dbo.PopulationRegistration");
            DropTable("dbo.HouseListing");
        }
    }
}
