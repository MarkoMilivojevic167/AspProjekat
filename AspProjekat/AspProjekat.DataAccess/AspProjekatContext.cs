using AspProjekat.Domain;
using Microsoft.EntityFrameworkCore;
using AspProjekat.EfDataAccess.Configurations;

using System;
using AspProjekat.Domain.Entity;

namespace AspProjekat.EfDataAccess
{
    public class AspProjekatContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<Category>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Role>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Image>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsDeleted);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-P6DG4R7\MARKOSQL;Initial Catalog=test;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderInfo> OrderInfo { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
