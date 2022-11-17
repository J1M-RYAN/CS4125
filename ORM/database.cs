// Database.cs

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using CS4125.Data.AnimalData;
using CS4125.Data.UserData;

namespace CS4125.ORM
{
    
    public class DatabaseContext : DbContext
    {
        public DbSet<Site> SiteData { get; set; }

        public DbSet<Animal> AnimalData { get; set; }

        public DbSet<Farmer> FarmerData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }

    public class SiteData
    {
        public siteID { get; set; }
        public siteAddress { get; set; }
    }
    
    public class AnimalData
    {
        public animalID { get; set; }
        public animalType { get; set; }
        public animalDOB { get; set; }
        public animalBreed { get; set; }
        public animalGender { get; set; }
        public animalSiteID { get; set; }
    }
    
    public class FarmerData
    {
        public farmerID { get; set; }
        public farmerName { get; set; }
        public farmerEmail { get; set; }
    }
}