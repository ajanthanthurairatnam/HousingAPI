namespace Housing.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSystemSettings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ExtraLargeDevicePageSize = c.Int(nullable: false),
                        LargeDevicePageSize = c.Int(nullable: false),
                        MediumDevicePageSize = c.Int(nullable: false),
                        SmallDevicePageSize = c.Int(nullable: false),
                        ExtraSmallDevicePageSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemSettings");
        }
    }
}
