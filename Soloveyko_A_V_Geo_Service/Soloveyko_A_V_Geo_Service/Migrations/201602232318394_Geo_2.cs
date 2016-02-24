namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeoObjects",
                c => new
                    {
                        GeoObjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        GeoObjectType = c.Int(nullable: false),
                        AddressId = c.Int(),
                    })
                .PrimaryKey(t => t.GeoObjectId)
                .ForeignKey("dbo.Addresses", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        GeoObjectId = c.Int(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GeoObjectId)
                .ForeignKey("dbo.GeoObjects", t => t.GeoObjectId)
                .Index(t => t.GeoObjectId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        Region = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Building = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Locations", new[] { "GeoObjectId" });
            DropIndex("dbo.GeoObjects", new[] { "AddressId" });
            DropForeignKey("dbo.Locations", "GeoObjectId", "dbo.GeoObjects");
            DropForeignKey("dbo.GeoObjects", "AddressId", "dbo.Addresses");
            DropTable("dbo.Addresses");
            DropTable("dbo.Locations");
            DropTable("dbo.GeoObjects");
        }
    }
}
