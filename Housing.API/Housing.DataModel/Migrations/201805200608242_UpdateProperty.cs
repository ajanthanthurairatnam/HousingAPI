namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProperty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        PropertyShortDescription = c.String(nullable: false, maxLength: 30, unicode: false),
                        PropertyDescription = c.String(nullable: false, maxLength: 8000, unicode: false),
                        PropertyFeatures = c.String(nullable: false, maxLength: 8000, unicode: false),
                        PropertyLocation = c.String(nullable: false, maxLength: 30, unicode: false),
                        PropertyCreatedDate = c.DateTime(nullable: false),
                        PropertyCreatedBy = c.Int(nullable: false),
                        PropertyUpdatedDate = c.DateTime(nullable: false),
                        PropertyUpdatedBy = c.Int(nullable: false),
                        PropertyType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PropertyTypes", t => t.PropertyType_ID)
                .Index(t => t.PropertyType_ID);
            
            CreateTable(
                "dbo.PropertyTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyTypeDescription = c.String(nullable: false, maxLength: 50, unicode: false),
                        PropertyTypeCreatedDate = c.DateTime(nullable: false),
                        PropertyTypeCreatedBy = c.Int(nullable: false),
                        PropertyTypeUpdatedDate = c.DateTime(nullable: false),
                        PropertyTypeUpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "PropertyType_ID", "dbo.PropertyTypes");
            DropIndex("dbo.Properties", new[] { "PropertyType_ID" });
            DropTable("dbo.PropertyTypes");
            DropTable("dbo.Properties");
        }
    }
}
