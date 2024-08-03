using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Productveriation
    {
        [Key]
        public int veriationId { get; set; }
        public string veriationName { get; set; }
        public int costprice { get; set; }
        public int RetailerPrice { get; set; }
        public int Quantity { get; set; }
        public string? image { get; set;}
        public int productId { get; set;}
        //public virtual Product Product {get; set;}
        [ForeignKey("Color")]
        public int ColoId { get; set; }
        //public virtual Color Color {get; set;}
        public int categoryId { get; set; }
        //public virtual Category Category { get; set;}
        public int BrandId { get; set; }
        //public virtual Brand Brand { get; set;}
        public int StatusId { get; set; }
        //public virtual Status Status { get; set;}
        public DateTime CreateDate { get; set;}
        public DateTime Lastmodifield {get; set;}
        [NotMapped]
        public IFormFile profilepicture {get; set;}
    }
}

