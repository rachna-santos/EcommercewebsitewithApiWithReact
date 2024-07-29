using Microsoft.AspNetCore.Identity;

namespace EcommercewebsitewithApi.Model
{
    public class ApplicationUser :IdentityUser
    {
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public DateTime createdate { get; set; }
        public DateTime Lastmodifieddate { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<Cart> cart { get; set; }


    }
}
