namespace EcommercewebsitewithApi.Model
{
    public class Role 
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public int StatusId { get; set; }
        //public virtual Status Status { get; set; }
        public int CompanyId { get; set; }
        //public virtual Company Company { get; set; }
        public DateTime createdate { get; set; }
        public DateTime Lastmodifieddate {get; set; }
    }
}
