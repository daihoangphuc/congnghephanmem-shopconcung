using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLy_ShopConCung.Models;

namespace QuanLy_ShopConCung.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set;}
        public DbSet<Models.Category> Categories { get; set;}
        public DbSet<Models.Size> Sizes { get; set;}
        public DbSet<Models.Brand> Brands { get; set;}
        public DbSet<Models.Customers> Customers { get; set;}
        public DbSet<Models.Orders> Orders { get; set;}
        public DbSet<Models.Staffs> Staffs { get; set;}
        public DbSet<Models.User> User { get; set;}
    }
}