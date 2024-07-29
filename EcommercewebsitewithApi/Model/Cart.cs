using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}

