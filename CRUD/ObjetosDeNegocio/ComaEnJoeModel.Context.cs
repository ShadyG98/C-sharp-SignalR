﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObjetosDeNegocio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ComaEnJoeDBEntities : DbContext
    {
        public ComaEnJoeDBEntities()
            : base("name=ComaEnJoeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cheffs> Cheffs { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClientesDatosAdicionales> ClientesDatosAdicionales { get; set; }
        public virtual DbSet<Mesas> Mesas { get; set; }
        public virtual DbSet<MesasPorSalon> MesasPorSalon { get; set; }
        public virtual DbSet<MesasTipos> MesasTipos { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Platos> Platos { get; set; }
        public virtual DbSet<PlatosTipos> PlatosTipos { get; set; }
        public virtual DbSet<Salones> Salones { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
