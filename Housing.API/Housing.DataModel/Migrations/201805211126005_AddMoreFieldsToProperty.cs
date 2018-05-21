namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreFieldsToProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Properties", "PropertyPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Properties", "Bedrooms", c => c.Int());
            AddColumn("dbo.Properties", "Restrooms", c => c.Int());
            AddColumn("dbo.Properties", "CarParks", c => c.Int());
            AddColumn("dbo.Properties", "PropertyAdvertisementStart", c => c.DateTime());
            AddColumn("dbo.Properties", "PropertyAdvertisementEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Properties", "PropertyAdvertisementEnd");
            DropColumn("dbo.Properties", "PropertyAdvertisementStart");
            DropColumn("dbo.Properties", "CarParks");
            DropColumn("dbo.Properties", "Restrooms");
            DropColumn("dbo.Properties", "Bedrooms");
            DropColumn("dbo.Properties", "PropertyPrice");
        }
    }
}
