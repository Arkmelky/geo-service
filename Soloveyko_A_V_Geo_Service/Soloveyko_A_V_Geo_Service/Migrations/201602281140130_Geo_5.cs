namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GeoObjects", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.GeoObjects", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.GeoObjectTypes", "GeoObjectTypeName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GeoObjectTypes", "GeoObjectTypeName", c => c.String());
            AlterColumn("dbo.GeoObjects", "Description", c => c.String());
            AlterColumn("dbo.GeoObjects", "Name", c => c.String());
        }
    }
}
