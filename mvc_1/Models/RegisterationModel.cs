using System.ComponentModel.DataAnnotations;

namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {
    public class RegisterationModel
        {

        [Key]
        public int regid { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string LastName { get; set; }
        public decimal MobileNo { get; set; }

        public string Email { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        }
    }
