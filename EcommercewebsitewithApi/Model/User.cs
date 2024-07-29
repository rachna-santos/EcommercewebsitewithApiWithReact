using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace EcommercewebsitewithApi.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        public int CompanyId { get; set; }
        //public virtual Company  Company { get; set; }
        public DateTime createdate { get; set; }
        public DateTime Lastmodifieddate { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        //public ICollection<Order> orders { get; set;}

    }

}

