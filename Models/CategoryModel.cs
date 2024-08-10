using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {
    public class CategoryModel         {

        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }


        }
    }
