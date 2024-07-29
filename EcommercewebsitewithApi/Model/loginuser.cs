using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class loginuser
    {
        [Key]
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
