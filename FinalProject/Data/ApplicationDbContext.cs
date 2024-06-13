using FinalProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data (if needed)
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Smartphones" },
                new Category { CategoryId = 2, Name = "Accessories" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "iPhone 13", Price = 999.99m, Description = "Latest iPhone model", CategoryId = 1 },
                new Product { ProductId = 2, Name = "Samsung Galaxy S21", Price = 799.99m, Description = "Latest Samsung model", CategoryId = 1 }
            );
        }
    }
}