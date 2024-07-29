using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Confirmpassword { get; set; }
    }
}

