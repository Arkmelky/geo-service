namespace Soloveyko_A_V_Geo_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Geo_4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "Country", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Region", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Street", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Addresses", "Building", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Building", c => c.String());
            AlterColumn("dbo.Addresses", "Street", c => c.String());
            AlterColumn("dbo.Addresses", "City", c => c.String());
            AlterColumn("dbo.Addresses", "Region", c => c.String());
            AlterColumn("dbo.Addresses", "Country", c => c.String());
        }
    }
}
