using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class userCountry
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
    }
}
