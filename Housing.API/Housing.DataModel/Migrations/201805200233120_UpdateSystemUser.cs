namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSystemUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SystemUsers", "SystemUserCode", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserName", c => c.String(nullable: false, maxLength: 15, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserTitle", c => c.String(nullable: false, maxLength: 5, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserFirstName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserLastName", c => c.String(nullable: false, maxLength: 30, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserGender", c => c.Int(nullable: false));
            AlterColumn("dbo.SystemUsers", "SystemUserEmail", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserMobile", c => c.String(nullable: false, maxLength: 20, unicode: false));
            AlterColumn("dbo.SystemUsers", "SystemUserLandLine", c => c.String(nullable: false, maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SystemUsers", "SystemUserLandLine", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserMobile", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserEmail", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserGender", c => c.Int());
            AlterColumn("dbo.SystemUsers", "SystemUserLastName", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserFirstName", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserTitle", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserName", c => c.String());
            AlterColumn("dbo.SystemUsers", "SystemUserCode", c => c.String());
        }
    }
}
