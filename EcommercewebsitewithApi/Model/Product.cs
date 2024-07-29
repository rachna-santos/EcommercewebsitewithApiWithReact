using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int quantity { get; set; }
        [Required]
        public int Discount { get; set; }
        public string? ImagePath { get; set; }
        [Required]
        public int subCategoryId { get; set; }
        //public virtual SubCategory SubCategory { get; set; }
        [Required]
        public int CategoryId { get; set; }
        //public virtual Category Category { get; set; }

        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
        [Required]
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        [NotMapped]
        public IFormFile image { get; set; }

    }

}
