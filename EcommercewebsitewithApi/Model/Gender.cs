using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommercewebsitewithApi.Model
{
    public class Gender
    {
        [Key]
        public int genderId { get; set; }
        public string genderName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        [NotMapped]
        public IFormFile image { get; set; }    

    }
}
