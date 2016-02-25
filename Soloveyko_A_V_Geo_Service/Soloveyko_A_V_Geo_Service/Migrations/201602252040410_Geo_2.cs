namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeoObjectTypes",
                c => new
                    {
                        GeoObjectTypeId = c.Int(nullable: false, identity: true),
                        GeoObjectTypeName = c.String(),
                    })
                .PrimaryKey(t => t.GeoObjectTypeId);
            
            AddColumn("dbo.GeoObjects", "GeoObjectTypeId", c => c.Int(nullable: false));
            AddForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes", "GeoObjectTypeId", cascadeDelete: false);
            CreateIndex("dbo.GeoObjects", "GeoObjectTypeId");
            DropColumn("dbo.GeoObjects", "GeoObjectType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GeoObjects", "GeoObjectType", c => c.Int(nullable: false));
            DropIndex("dbo.GeoObjects", new[] { "GeoObjectTypeId" });
            DropForeignKey("dbo.GeoObjects", "GeoObjectTypeId", "dbo.GeoObjectTypes");
            DropColumn("dbo.GeoObjects", "GeoObjectTypeId");
            DropTable("dbo.GeoObjectTypes");
        }
    }
}
