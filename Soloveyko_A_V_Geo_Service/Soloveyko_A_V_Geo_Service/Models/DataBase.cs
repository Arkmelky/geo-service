using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class DataBase:DbContext
    {
        public DataBase()
            : base("GeoObjects_db")
        {
        
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        //public DbSet<UserProfile> UserProfiles { get; set; }
        
        //Main obj
        public DbSet<GeoObject> GeoObjects { get; set; }
        
        //Address Objects
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //public DbSet<Region> Regions { get; set; }
        //public DbSet<City> Cities { get; set; }
        //public DbSet<Street> Streets { get; set; }
        //public DbSet<Building> Buildings { get; set; }

        //Location obj
        public DbSet<Location> Locations { get; set; }
    }
}