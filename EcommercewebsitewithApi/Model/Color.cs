using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Color
    {
        [Key]
        public int ColorId { get; set;}
        public string colorName { get; set; }
        public string? ImagePath { get; set; }
        public string colorcode1 { get; set; }
        public string colorcode2 { get; set; }
        public DateTime Createdate { get; set;}
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        [NotMapped]
        public IFormFile image { get; set; }

    }
}
