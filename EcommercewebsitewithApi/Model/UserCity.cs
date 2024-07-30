using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class UserCity
    {
        [Key]
        public int CityId {get; set;}
        public string CityName { get; set; }
        public int CountryId { get; set; }

        //public virtual Country Country { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }

    }
}
