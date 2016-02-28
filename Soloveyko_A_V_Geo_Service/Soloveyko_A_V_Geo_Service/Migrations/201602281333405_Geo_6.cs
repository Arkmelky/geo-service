namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "GeoObjectInfo", c => c.String());
            AddColumn("dbo.Locations", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "Discriminator");
            DropColumn("dbo.Locations", "GeoObjectInfo");
        }
    }
}
