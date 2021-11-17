using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class NatusVincenzoDbContext : DbContext
    {
        public NatusVincenzoDbContext()
            : base("name=NatusVincenzoDbContext")
        {
        }

        public virtual DbSet<Advertise> Advertises { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<GroupProduct> GroupProducts { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Order)
                .WithRequired(e => e.Customer);

            modelBuilder.Entity<OrderDetail>()
                .HasOptional(e => e.Order)
                .WithRequired(e => e.OrderDetail);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.GroupProduct)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.OrderDetail)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Province>()
                .HasOptional(e => e.Shop)
                .WithRequired(e => e.Province);

            modelBuilder.Entity<Shop>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Support>()
                .Property(e => e.Nick)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
