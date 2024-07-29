using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class Country
    {
        [Key]
        public int countryId { get; set; }
        [Required]
        [MaxLength(200)]
        public string countryName { get; set; }
    }
}
