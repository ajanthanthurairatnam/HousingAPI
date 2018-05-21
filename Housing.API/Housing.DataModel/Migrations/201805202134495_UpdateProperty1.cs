namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProperty1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "PropertyAdvertisementStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Properties", "PropertyAdvertisementFinishDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Properties", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Properties", "AdvertisementType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "AdvertisementType");
            DropColumn("dbo.Properties", "IsActive");
            DropColumn("dbo.Properties", "PropertyAdvertisementFinishDate");
            DropColumn("dbo.Properties", "PropertyAdvertisementStartDate");
        }
    }
}
