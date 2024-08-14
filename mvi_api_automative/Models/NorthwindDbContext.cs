using Microsoft.EntityFrameworkCore;
using WebApp2.Areas.Suppliers.Models;

namespace WebApp2.Models
    {

  


    public class NorthwindDbContext : DbContext
        {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options)
            {

            }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SuppModel> Suppliers { get; set; }
        }

    }
