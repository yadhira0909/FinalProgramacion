﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProgramacion.App_Start.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FPEntities2 : DbContext
    {
        public FPEntities2()
            : base("name=FPEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<Nomina> Nomina { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Salida> Salida { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }
    }
}
