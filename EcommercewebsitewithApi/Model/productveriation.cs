using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class productveriation
    {
        [Key]
        public int veriationId { get; set; }
        public string veriationName { get; set; }
        public int costprice { get; set; }
        public int RetailerPrice { get; set; }
        public int Quantity { get; set; }
        public string? image { get; set; }
        public int productId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Color")]
        public int Id { get; set; }
        public virtual Color Color { get; set; }
        public int SizeId { get; set; }
        public virtual Size Size { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }
        public int subcategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public int categorystyleid { get; set; }
        public virtual CategoryStyle CategoryStyle { get; set; }
        public int productseasonId { get; set; }
        public virtual ProductSeason ProductSeason { get; set; }
        public int genderId { get; set; }
        public virtual Gender Gender { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Lastmodifield { get; set; }
        [NotMapped]
        public IFormFile profilepicture { get; set; }
    }
}
