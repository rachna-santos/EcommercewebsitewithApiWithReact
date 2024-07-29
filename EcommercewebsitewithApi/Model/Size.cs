using System.ComponentModel.DataAnnotations;


namespace EcommercewebsitewithApi.Model
{
    public class Size
    {
        [Key]
        public int SizeId {get; set;}
        public string SizeName { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime lastdate { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}

