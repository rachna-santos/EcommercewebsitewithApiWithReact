using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Order_Details
    {
        [Key]
        public int order_detailsId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int price { get; set; }
        public  int quantity { get; set; }
        public int order_id { get; set; }
        [ForeignKey("order_id")]
        public virtual Order Order { get; set; }    

    }

}
