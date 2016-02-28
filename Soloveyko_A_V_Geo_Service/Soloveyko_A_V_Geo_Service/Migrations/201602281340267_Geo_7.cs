namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Locations", "GeoObjectInfo");
            DropColumn("dbo.Locations", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Locations", "GeoObjectInfo", c => c.String());
        }
    }
}
