﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ArendaEntities : DbContext
    {
        public ArendaEntities()
            : base("name=ArendaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dogovor> Dogovor { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<Tip_ship> Tip_ship { get; set; }
        public virtual DbSet<Tip_sotrudnika> Tip_sotrudnika { get; set; }
    }
}
