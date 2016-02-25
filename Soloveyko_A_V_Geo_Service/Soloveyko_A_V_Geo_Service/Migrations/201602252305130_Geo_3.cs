namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes");
            DropIndex("dbo.GeoObjects", new[] { "GeoObjectTypeId" });
            AlterColumn("dbo.GeoObjects", "GeoObjectTypeId", c => c.Int());
            AddForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes", "GeoObjectTypeId");
            CreateIndex("dbo.GeoObjects", "GeoObjectTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.GeoObjects", new[] { "GeoObjectTypeId" });
            DropForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes");
            AlterColumn("dbo.GeoObjects", "GeoObjectTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.GeoObjects", "GeoObjectTypeId");
            AddForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes", "GeoObjectTypeId", cascadeDelete: true);
        }
    }
}
