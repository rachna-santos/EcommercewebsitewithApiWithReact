using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<ApplicationUser> users { get; set; }
        public ICollection<ApplicationRole> Role { get; set; }

    }
}

