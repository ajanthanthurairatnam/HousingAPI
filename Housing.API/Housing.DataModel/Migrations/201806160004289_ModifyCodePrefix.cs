namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCodePrefix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CodePrefixes", "AuditRecordCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CodePrefixes", "AuditRecordCodeNextNo");
        }
    }
}
