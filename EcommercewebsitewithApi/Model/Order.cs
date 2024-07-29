using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Order
    {
        [Key]
        public int orderid { get; set;}
        public int order_No { get; set;}
        public int total_order { get; set;}
        public string UserId { get; set; }
        public virtual ApplicationUser applicationUser { get; set;}
        public DateTime Createdate { get; set;}
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set;}
    }
}


