namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePropertyDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Properties", "PropertyAdvertisementStartDate", c => c.DateTime());
            AlterColumn("dbo.Properties", "PropertyAdvertisementFinishDate", c => c.DateTime());
            DropColumn("dbo.Properties", "PropertyAdvertisementStart");
            DropColumn("dbo.Properties", "PropertyAdvertisementEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Properties", "PropertyAdvertisementEnd", c => c.DateTime());
            AddColumn("dbo.Properties", "PropertyAdvertisementStart", c => c.DateTime());
            AlterColumn("dbo.Properties", "PropertyAdvertisementFinishDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Properties", "PropertyAdvertisementStartDate", c => c.DateTime(nullable: false));
        }
    }
}
