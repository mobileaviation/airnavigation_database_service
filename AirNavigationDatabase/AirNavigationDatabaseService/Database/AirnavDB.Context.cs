﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNavigationDatabaseService.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class airnavdbEntities : DbContext
    {
        public airnavdbEntities()
            : base("name=airnavdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> tbl_Countries { get; set; }
        public virtual DbSet<Fir> tbl_Firs { get; set; }
        public virtual DbSet<Fix> tbl_Fixes { get; set; }
        public virtual DbSet<Navaid> tbl_Navaids { get; set; }
        public virtual DbSet<Region> tbl_Regions { get; set; }
        public virtual DbSet<Tile> tbl_Tiles { get; set; }
        public virtual DbSet<Airspace> tbl_Airspaces { get; set; }
        public virtual DbSet<Link> tbl_Links1 { get; set; }
        public virtual DbSet<Airport> tbl_Airports { get; set; }
        public virtual DbSet<Frequency> tbl_Frequencies { get; set; }
        public virtual DbSet<Runway> tbl_Runways { get; set; }
    }
}
