﻿using Airlines.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.PersistanceContextEF
{
    class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Airlines.Migrations.Configuration>("SchoolDBConnectionString"));
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
      //public object Course { get; internal set; }


        public DbSet<Kierunek> Kierunek { get; set; }
        public DbSet<Lot> Lot { get; set; }
        public DbSet<TypSamolotu> TypSamolotu { get; set; }
        public DbSet<Samolot> Samolot { get; set; }
        public DbSet<Odprawa> Odprawa { get; set; }
        public DbSet<Pasazer> Pasazer { get; set; }
        public DbSet<OdprawaPasazer> OdprawaPasazer { get; set; }
        public DbSet<Stanowisko> Stanowisko { get; set; }
        public DbSet<Zalogant> Zalogant { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)

        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
