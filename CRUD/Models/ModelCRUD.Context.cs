﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CURSOMVCEntities : DbContext
    {
        public CURSOMVCEntities()
            : base("name=CURSOMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Edificio> Edificio { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Piso> Piso { get; set; }
        public virtual DbSet<Puerta> Puerta { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}