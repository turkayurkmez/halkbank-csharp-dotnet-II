﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eshop.DataAccess.DataContext;

#nullable disable

namespace eshop.DataAccess.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    [Migration("20240214071521_initialize")]
    partial class initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eshop.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kırtasiye"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ev Eşyası"
                        });
                });

            modelBuilder.Entity("eshop.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "1 TB SSD 32 GB Ram",
                            ImageUrl = "https://cdn.dsmcdn.com/ty337/product/media/images/20220221/21/54889095/393766841/5/5_org_zoom.jpg",
                            Name = "Dell XPS 13",
                            Price = 90000m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Beyaz yazı tahtası",
                            ImageUrl = "https://cdn.dsmcdn.com/ty337/product/media/images/20220221/21/54889095/393766841/5/5_org_zoom.jpg",
                            Name = "Beyaz Tahta",
                            Price = 550m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Kanepe ve koltuklar",
                            ImageUrl = "https://cdn.dsmcdn.com/ty337/product/media/images/20220221/21/54889095/393766841/5/5_org_zoom.jpg",
                            Name = "Koltuk Takımız",
                            Price = 45000m,
                            Stock = 150
                        });
                });

            modelBuilder.Entity("eshop.Entities.Product", b =>
                {
                    b.HasOne("eshop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eshop.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
