namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodePrefixes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserCodePrefix = c.String(),
                        UserCodeIncrementBy = c.Int(nullable: false),
                        UserCodeNextNo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SystemUserCode = c.String(),
                        SystemUserName = c.String(),
                        SystemUseType = c.Int(nullable: false),
                        SystemUserTitle = c.String(),
                        SystemUserFirstName = c.String(),
                        SystemUserLastName = c.String(),
                        SystemUserGender = c.Int(),
                        SystemUserEmail = c.String(),
                        SystemUserMobile = c.String(),
                        SystemUserLandLine = c.String(),
                        SystemUserCreatedDate = c.DateTime(nullable: false),
                        SystemUserCreatedBy = c.Int(nullable: false),
                        SystemUserUpdatedDate = c.DateTime(nullable: false),
                        SystemUserUpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemUsers");
            DropTable("dbo.CodePrefixes");
        }
    }
}
