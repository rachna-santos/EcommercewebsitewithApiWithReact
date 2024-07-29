using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string Phone_number { get; set; }
        public string CompanyAddress { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTime createdate { get; set; }
        public DateTime Lastmodifieddate { get; set; }
        public ICollection<ApplicationUser> users { get; set; }
        public ICollection<ApplicationRole> Role { get; set; }
    }
}

