namespace Rent_ship.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Rent_Model : DbContext
    {
        public Rent_Model()
            : base("name=Rent_Model")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dogovor> Dogovor { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<Tip_ship> Tip_ship { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Dogovor)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.CFK);

            modelBuilder.Entity<Dogovor>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ship>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.Manufacture)
                .IsUnicode(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.Sostoyanie)
                .IsUnicode(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.Sum_day)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.Dogovor)
                .WithOptional(e => e.Ship)
                .HasForeignKey(e => e.LFK);

            modelBuilder.Entity<Sotrudnik>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Sotrudnik>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<Sotrudnik>()
                .HasMany(e => e.Dogovor)
                .WithOptional(e => e.Sotrudnik)
                .HasForeignKey(e => e.SFK);

            modelBuilder.Entity<Tip_ship>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Tip_ship>()
                .HasMany(e => e.Ship)
                .WithRequired(e => e.Tip_ship)
                .HasForeignKey(e => e.LTFK)
                .WillCascadeOnDelete(false);
        }
    }
}
