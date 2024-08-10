using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {
    public class NorthwindDBContext : DbContext
        {

        public NorthwindDBContext(DbContextOptions<NorthwindDBContext> options) : base(options)
            {

            }
        public DbSet<CategoryModel> Categories { get; set; } 

        public DbSet<ProductModel> Products { get; set; }
        }
    }
