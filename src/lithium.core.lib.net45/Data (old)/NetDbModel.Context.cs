﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lithium.core.lib.net45.Data__old_
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NetDbContext_old : DbContext
    {
        public NetDbContext_old()
            : base("name=NetDbContext_old")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Model> Models { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Mfgr> Mfgrs { get; set; }
        public DbSet<FactorySettings> FactorySettingses { get; set; }
        public DbSet<OwnerType> OwnerTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OperatingSystem> OperatingSystems { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<NetworkNode> NetworkNodes { get; set; }
        public DbSet<IpAddrAssignType> IpAddrAssignTypes { get; set; }
        public DbSet<NetworkServiceType> NetworkServiceTypes { get; set; }
        public DbSet<NetworkService> NetworkServices { get; set; }
        public DbSet<Interface> Interfaces { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<InterfaceType> InterfaceTypes { get; set; }
        public DbSet<NetConnectorType> NetConnectorTypes { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
