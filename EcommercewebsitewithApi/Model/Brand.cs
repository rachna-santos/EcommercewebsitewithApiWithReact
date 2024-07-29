using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Title { get; set; }
        public string BrandDescription { get; set; }
        public string BrandPhone { get; set; }
        public string? ImagePath {get;set;}
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        [NotMapped]
        public IFormFile image { get; set; }    
    }
}

