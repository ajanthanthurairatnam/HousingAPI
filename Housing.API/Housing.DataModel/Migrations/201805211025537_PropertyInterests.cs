namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyInterests : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyInterestedUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyInterestedUserCreatedDate = c.DateTime(nullable: false),
                        PropertyInterestedUserCreatedBy = c.Int(nullable: false),
                        PropertyInterestedUserUpdatedDate = c.DateTime(nullable: false),
                        PropertyInterestedUserUpdatedBy = c.Int(nullable: false),
                        Property_ID = c.Int(),
                        SystemUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Properties", t => t.Property_ID)
                .ForeignKey("dbo.SystemUsers", t => t.SystemUser_ID)
                .Index(t => t.Property_ID)
                .Index(t => t.SystemUser_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyInterestedUsers", "SystemUser_ID", "dbo.SystemUsers");
            DropForeignKey("dbo.PropertyInterestedUsers", "Property_ID", "dbo.Properties");
            DropIndex("dbo.PropertyInterestedUsers", new[] { "SystemUser_ID" });
            DropIndex("dbo.PropertyInterestedUsers", new[] { "Property_ID" });
            DropTable("dbo.PropertyInterestedUsers");
        }
    }
}
