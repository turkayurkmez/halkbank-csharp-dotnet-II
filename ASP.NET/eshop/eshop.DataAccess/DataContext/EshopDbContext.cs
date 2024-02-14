using eshop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.DataContext
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=HalkShopDb;Integrated Security=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(150);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Category>().HasData(
                  new Category() { Id = 1, Name = "Elektronik" },
                  new Category() { Id = 2, Name = "Kırtasiye" },
                  new Category() { Id = 3, Name = "Ev Eşyası" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Dell XPS 13", CategoryId = 1, Price = 90000, Stock = 150, Description = "1 TB SSD 32 GB Ram" },
                new Product() { Id = 2, Name = "Beyaz Tahta", CategoryId = 2, Price = 550, Stock = 150, Description = "Beyaz yazı tahtası" },
                new Product() { Id = 3, Name = "Koltuk Takımız", CategoryId = 3, Price = 45000, Stock = 150, Description = "Kanepe ve koltuklar" }
            );

        }

    }
}
