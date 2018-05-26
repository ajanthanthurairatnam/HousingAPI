namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCodePrefix1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodePrefixes", "AuditRecordCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "AuditRecordCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "AgentCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "AgentCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "AgentCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddColumn("dbo.CodePrefixes", "BuyerCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "BuyerCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "BuyerCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddColumn("dbo.CodePrefixes", "PropertyCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "PropertyCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "PropertyCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddColumn("dbo.CodePrefixes", "PropertyImageCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "PropertyImageCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "PropertyImageCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AddColumn("dbo.CodePrefixes", "VendorCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AddColumn("dbo.CodePrefixes", "VendorCodeIncrementBy", c => c.Int(nullable: false));
            AddColumn("dbo.CodePrefixes", "VendorCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CodePrefixes", "VendorCodeNextNo");
            DropColumn("dbo.CodePrefixes", "VendorCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "VendorCodePrefix");
            DropColumn("dbo.CodePrefixes", "PropertyImageCodeNextNo");
            DropColumn("dbo.CodePrefixes", "PropertyImageCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "PropertyImageCodePrefix");
            DropColumn("dbo.CodePrefixes", "PropertyCodeNextNo");
            DropColumn("dbo.CodePrefixes", "PropertyCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "PropertyCodePrefix");
            DropColumn("dbo.CodePrefixes", "BuyerCodeNextNo");
            DropColumn("dbo.CodePrefixes", "BuyerCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "BuyerCodePrefix");
            DropColumn("dbo.CodePrefixes", "AgentCodeNextNo");
            DropColumn("dbo.CodePrefixes", "AgentCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "AgentCodePrefix");
            DropColumn("dbo.CodePrefixes", "AuditRecordCodeIncrementBy");
            DropColumn("dbo.CodePrefixes", "AuditRecordCodePrefix");
        }
    }
}
