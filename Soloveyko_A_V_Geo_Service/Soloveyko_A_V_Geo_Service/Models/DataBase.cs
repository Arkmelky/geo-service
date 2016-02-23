using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class DataBase:DbContext
    {
        private static DataBase dataBase;
        private static object flag = new object();

        private DataBase()
            : base("GeoObjects_db")
        {
        
        }

        public static DataBase GetDbContext()
        {
            if (dataBase == null)
            {
                lock (flag)
                {
                    if (dataBase == null)
                    {
                        dataBase = new DataBase();
                    }
                }
            }
            return dataBase;
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