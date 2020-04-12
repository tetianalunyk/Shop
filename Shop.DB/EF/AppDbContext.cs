using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Shop.DB.Entities;

namespace Shop.DB.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Entities.Type> Types { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ItemColor>()
                .HasKey(t => new { t.ItemId, t.ColorId });
            builder.Entity<ItemColor>()
                .HasOne(ue => ue.Item)
                .WithMany(u => u.Colors)
                .HasForeignKey(ue => ue.ColorId);
            builder.Entity<ItemColor>()
                .HasOne(ue => ue.Color)
                .WithMany(u => u.Items)
                .HasForeignKey(ue => ue.ItemId);

            builder.Entity<ItemType>()
                .HasKey(t => new { t.ItemId, t.TypeId });
            builder.Entity<ItemType>()
                .HasOne(ue => ue.Item)
                .WithMany(u => u.Types)
                .HasForeignKey(ue => ue.TypeId);
            builder.Entity<ItemType>()
                .HasOne(ue => ue.Type)
                .WithMany(u => u.Items)
                .HasForeignKey(ue => ue.ItemId);

            builder.Entity<CategoryType>()
               .HasKey(t => new { t.TypeId, t.CategoryId });
            builder.Entity<CategoryType>()
                .HasOne(ue => ue.Category)
                .WithMany(u => u.Types)
                .HasForeignKey(ue => ue.TypeId);
        }
    }
}
