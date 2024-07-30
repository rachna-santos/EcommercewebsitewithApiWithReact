
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Customer
    {
        [Key]
        public int Id {get; set;}
        public string Name { get; set; }
        public string Email { get; set;}
        public string Password { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Telephone { get; set; }
        public int CityId { get; set; }
        //public virtual City City { get; set; }
        public int CountryId { get; set; }
        //public virtual Country Country { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }

    }
}
