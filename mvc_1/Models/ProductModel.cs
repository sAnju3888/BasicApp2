using System.ComponentModel.DataAnnotations;

namespace NorthwindDemoEFCoreDependencyInjection2.Models

    {
    public class ProductModel
        {

        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public int  UnitPrice { get; set; }

        }
    }
