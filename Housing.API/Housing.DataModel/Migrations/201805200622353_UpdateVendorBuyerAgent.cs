namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateVendorBuyerAgent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AgentCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        SystemUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SystemUsers", t => t.SystemUser_ID)
                .Index(t => t.SystemUser_ID);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BuyerCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        SystemUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SystemUsers", t => t.SystemUser_ID)
                .Index(t => t.SystemUser_ID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VendorCode = c.String(nullable: false, maxLength: 10, unicode: false),
                        SystemUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SystemUsers", t => t.SystemUser_ID)
                .Index(t => t.SystemUser_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendors", "SystemUser_ID", "dbo.SystemUsers");
            DropForeignKey("dbo.Buyers", "SystemUser_ID", "dbo.SystemUsers");
            DropForeignKey("dbo.Agents", "SystemUser_ID", "dbo.SystemUsers");
            DropIndex("dbo.Vendors", new[] { "SystemUser_ID" });
            DropIndex("dbo.Buyers", new[] { "SystemUser_ID" });
            DropIndex("dbo.Agents", new[] { "SystemUser_ID" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Buyers");
            DropTable("dbo.Agents");
        }
    }
}
