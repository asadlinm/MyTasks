using Microsoft.EntityFrameworkCore;
using MyTasks.Models;

namespace MyTasks.Concrete
{
    public class ProductContect:DbContext
    {
        protected override void  OnConfiguring(  DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EEB8HIK;database=ProductsDB;integrated security=true;");
        }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMainCategory> ProductMainCategories { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
