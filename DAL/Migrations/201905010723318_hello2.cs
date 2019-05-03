namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hello2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member");
            DropForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member");
            DropPrimaryKey("dbo.Member");
            AlterColumn("dbo.Member", "MemberID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Member", "MemberID");
            AddForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
            AddForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member");
            DropForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member");
            DropPrimaryKey("dbo.Member");
            AlterColumn("dbo.Member", "MemberID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Member", "MemberID");
            AddForeignKey("dbo.UserRequestStatus", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
            AddForeignKey("dbo.PopulationRegistration", "MemberID", "dbo.Member", "MemberID", cascadeDelete: true);
        }
    }
}
