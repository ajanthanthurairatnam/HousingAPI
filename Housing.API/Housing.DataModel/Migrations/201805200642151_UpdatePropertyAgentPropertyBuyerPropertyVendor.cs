namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePropertyAgentPropertyBuyerPropertyVendor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyAgents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyAgentCreatedDate = c.DateTime(nullable: false),
                        PropertyAgentCreatedBy = c.Int(nullable: false),
                        PropertyAgentUpdatedDate = c.DateTime(nullable: false),
                        PropertyAgentUpdatedBy = c.Int(nullable: false),
                        Property_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Properties", t => t.Property_ID)
                .Index(t => t.Property_ID);
            
            CreateTable(
                "dbo.PropertyBuyers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyBuyerCreatedDate = c.DateTime(nullable: false),
                        PropertyBuyerCreatedBy = c.Int(nullable: false),
                        PropertyBuyerUpdatedDate = c.DateTime(nullable: false),
                        PropertyBuyerUpdatedBy = c.Int(nullable: false),
                        Property_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Properties", t => t.Property_ID)
                .Index(t => t.Property_ID);
            
            CreateTable(
                "dbo.PropertyVendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertyVendorCreatedDate = c.DateTime(nullable: false),
                        PropertyVendorCreatedBy = c.Int(nullable: false),
                        PropertyVendorUpdatedDate = c.DateTime(nullable: false),
                        PropertyVendorUpdatedBy = c.Int(nullable: false),
                        Property_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Properties", t => t.Property_ID)
                .Index(t => t.Property_ID);
            
            AddColumn("dbo.Agents", "AgentCreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Agents", "AgentCreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Agents", "AgentUpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Agents", "AgentUpdatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Buyers", "BuyerCreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Buyers", "BuyerCreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Buyers", "BuyerUpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Buyers", "BuyerUpdatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Vendors", "VendorCreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vendors", "VendorCreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Vendors", "VendorUpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vendors", "VendorUpdatedBy", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyVendors", "Property_ID", "dbo.Properties");
            DropForeignKey("dbo.PropertyBuyers", "Property_ID", "dbo.Properties");
            DropForeignKey("dbo.PropertyAgents", "Property_ID", "dbo.Properties");
            DropIndex("dbo.PropertyVendors", new[] { "Property_ID" });
            DropIndex("dbo.PropertyBuyers", new[] { "Property_ID" });
            DropIndex("dbo.PropertyAgents", new[] { "Property_ID" });
            DropColumn("dbo.Vendors", "VendorUpdatedBy");
            DropColumn("dbo.Vendors", "VendorUpdatedDate");
            DropColumn("dbo.Vendors", "VendorCreatedBy");
            DropColumn("dbo.Vendors", "VendorCreatedDate");
            DropColumn("dbo.Buyers", "BuyerUpdatedBy");
            DropColumn("dbo.Buyers", "BuyerUpdatedDate");
            DropColumn("dbo.Buyers", "BuyerCreatedBy");
            DropColumn("dbo.Buyers", "BuyerCreatedDate");
            DropColumn("dbo.Agents", "AgentUpdatedBy");
            DropColumn("dbo.Agents", "AgentUpdatedDate");
            DropColumn("dbo.Agents", "AgentCreatedBy");
            DropColumn("dbo.Agents", "AgentCreatedDate");
            DropTable("dbo.PropertyVendors");
            DropTable("dbo.PropertyBuyers");
            DropTable("dbo.PropertyAgents");
        }
    }
}
