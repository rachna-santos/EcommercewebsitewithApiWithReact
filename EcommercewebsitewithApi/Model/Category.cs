
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string? ImagePath { get; set; }
        public int subCategoryId { get; set; }
        //public virtual SubCategory SubCategory { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        [NotMapped]
        public IFormFile image { get; set; }

    }
}
