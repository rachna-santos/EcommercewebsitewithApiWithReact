using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class ProductImage
    {
        [Key]
        public int productimageId { get; set; }
        //public virtual Product Product { get; set; }
        public int productId { get; set; }
        public string iamgepath { get; set; }
        public string imagepath_thumb { get; set; }

        //public virtual Status Status { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Lastmodifield { get; set; }
        [NotMapped]
        public List<IFormFile> profilepicture { get; set; }
    }
}
