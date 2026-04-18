using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RetroVideoGameStore.Models;

namespace RetroVideoGameStore.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action" },
                new Category { Id = 2, Name = "Racing" },
                new Category { Id = 3, Name = "Sports" },
                new Category { Id = 4, Name = "Adventure" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "GTA V",
                    Price = 39.99,
                    CategoryId = 1,
                    Photo = "gta5.jpg",
                    Description = "Open world action game"
                },
                new Product
                {
                    Id = 2,
                    Name = "Need for Speed",
                    Price = 49.99,
                    CategoryId = 2,
                    Photo = "nfs.jpg",
                    Description = "Fast racing game"
                },
                new Product
                {
                    Id = 3,
                    Name = "FIFA 23",
                    Price = 59.99,
                    CategoryId = 3,
                    Photo = "fifa23.jpg",
                    Description = "Football simulation game"
                },
                new Product
                {
                    Id = 4,
                    Name = "Zelda",
                    Price = 69.99,
                    CategoryId = 4,
                    Photo = "zelda.jpg",
                    Description = "Adventure fantasy game"
                }
            );
        }
    }
}