
using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class customerlogin
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
    }
}
