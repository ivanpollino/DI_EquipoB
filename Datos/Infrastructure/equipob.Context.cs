﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Infrastructure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class equipobEntities1 : DbContext
    {
        public equipobEntities1()
            : base("name=equipobEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Administrador> Administrador { get; set; }
        public virtual DbSet<Monitor> Monitor { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Ususario_Normal> Ususario_Normal { get; set; }
    }
}
