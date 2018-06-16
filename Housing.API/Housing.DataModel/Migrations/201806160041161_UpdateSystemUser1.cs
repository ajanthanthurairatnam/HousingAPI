namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSystemUser1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SystemUsers", "SystemUserFirstName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserLastName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserEmail", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SystemUsers", "SystemUserEmail", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserLastName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserFirstName", c => c.String(nullable: false, maxLength: 30, unicode: false));
        }
    }
}
