namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAudit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuditRecords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AuditRecordCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        AuditTable = c.Int(nullable: false),
                        AuditType = c.Int(nullable: false),
                        AuditPreviousRecord = c.String(),
                        AuditCurrentRecord = c.String(),
                        AuditCreatedDate = c.DateTime(nullable: false),
                        AuditCreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PropertyImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyImageCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        PropertyImageName = c.String(nullable: false, maxLength: 30, unicode: false),
                        PropertyImageLocation = c.String(maxLength: 100, unicode: false),
                        PropertyImageCreatedDate = c.DateTime(nullable: false),
                        PropertyImageCreatedBy = c.Int(nullable: false),
                        PropertyImageUpdatedDate = c.DateTime(nullable: false),
                        PropertyImageUpdatedBy = c.Int(nullable: false),
                        Property_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Properties", t => t.Property_ID)
                .Index(t => t.Property_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyImages", "Property_ID", "dbo.Properties");
            DropIndex("dbo.PropertyImages", new[] { "Property_ID" });
            DropTable("dbo.PropertyImages");
            DropTable("dbo.AuditRecords");
        }
    }
}
