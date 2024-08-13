using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {
    public class FormDBContext : DbContext
        {

        public FormDBContext(DbContextOptions<FormDBContext> options) : base(options)
            {

            }
        public DbSet<RegisterationModel> Registers { get; set; }

        }
    }
