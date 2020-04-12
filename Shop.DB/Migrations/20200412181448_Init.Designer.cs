﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.DB.EF;

namespace Shop.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200412181448_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.DB.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Shop.DB.Entities.CategoryType", b =>
                {
                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TypeId", "CategoryId");

                    b.ToTable("CategoryType");
                });

            modelBuilder.Entity("Shop.DB.Entities.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Shop.DB.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fasad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hull")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SizesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("SizesId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Shop.DB.Entities.ItemColor", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemId", "ColorId");

                    b.HasIndex("ColorId");

                    b.ToTable("ItemColor");
                });

            modelBuilder.Entity("Shop.DB.Entities.ItemType", b =>
                {
                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemId", "TypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("Shop.DB.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Shop.DB.Entities.Sizes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Height")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Shop.DB.Entities.Type", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Shop.DB.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shop.DB.Entities.CategoryType", b =>
                {
                    b.HasOne("Shop.DB.Entities.Category", "Category")
                        .WithMany("Types")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.DB.Entities.Color", b =>
                {
                    b.HasOne("Shop.DB.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.DB.Entities.Item", b =>
                {
                    b.HasOne("Shop.DB.Entities.Photo", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.DB.Entities.Sizes", "Sizes")
                        .WithMany()
                        .HasForeignKey("SizesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.DB.Entities.ItemColor", b =>
                {
                    b.HasOne("Shop.DB.Entities.Item", "Item")
                        .WithMany("Colors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.DB.Entities.Color", "Color")
                        .WithMany("Items")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.DB.Entities.ItemType", b =>
                {
                    b.HasOne("Shop.DB.Entities.Type", "Type")
                        .WithMany("Items")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.DB.Entities.Item", "Item")
                        .WithMany("Types")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
