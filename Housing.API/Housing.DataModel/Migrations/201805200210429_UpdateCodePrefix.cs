namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCodePrefix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CodePrefixes", "UserCodePrefix", c => c.String(nullable: false, maxLength: 3, unicode: false));
            AlterColumn("dbo.CodePrefixes", "UserCodeNextNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CodePrefixes", "UserCodeNextNo", c => c.String());
            AlterColumn("dbo.CodePrefixes", "UserCodePrefix", c => c.String());
        }
    }
}
