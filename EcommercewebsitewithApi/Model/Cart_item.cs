using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class Cart_item
    {
        [Key]
        public int cart_item { get; set; }
        public int quantity { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product {get; set;}

    }
}
