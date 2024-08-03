
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class ShoppingCart
    {
        [Key]
        public int cartId {get; set;}

        [ForeignKey("Customer")]
        public int Id { get; set;}
        public virtual Customer Customer { get; set; }

        [ForeignKey("Productveriation")]
        public int veriationId { get; set; }
        public virtual Productveriation Productveriation  { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }    
        public int Quantity { get; set; }
        public int price { get; set;}
        public int bill { get; set; }
        public DateTime Createdate {get; set;}
        public DateTime lastdate {get; set;}


    }
}
