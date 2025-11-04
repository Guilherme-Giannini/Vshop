using Microsoft.EntityFrameworkCore;
using VShop.ProductApi.Models;

namespace VShop.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }
    public DbSet<Models.Category> Categories { get; set; }
    public DbSet<Models.Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        base.OnModelCreating(mb);
        mb.Entity<Category>().HasKey(c => c.CategoryId);
        mb.Entity<Category>()
            .Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();

        mb.Entity<Product>()
            .Property(c => c.Name)
            .HasMaxLength(100)
            .IsRequired();

        mb.Entity<Product>()
            .Property(c => c.ImageUrl)
            .HasMaxLength(255)
            .IsRequired();

        mb.Entity<Product>()
            .Property(c => c.Price)
            .HasPrecision(12, 2);
        mb.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        mb.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Material Escolar" },
            new Category { CategoryId = 2, Name = "Acessórios" }
        );
    }
}
