using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Soloveyko_A_V_Geo_Service.Models
{
    public class DataBase:DbContext
    {
        private static DataBase dataBase;
        private static object flag = new object();

        public DataBase()
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
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
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

    public class DataBaseRepository<TEntity> where TEntity : class
    {
        private DbContext dbContext;

        public DataBaseRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public TEntity Get(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbContext.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            dbContext.Set<TEntity>().AddOrUpdate(entity);
        }

        public void AddRange(IEnumerable<TEntity> etities)
        {
            foreach (var entity in etities)
            {
                dbContext.Set<TEntity>().Add(entity);    
            }
        }

        public void Remove(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                dbContext.Set<TEntity>().Remove(entity);
            }
        }
    }
}