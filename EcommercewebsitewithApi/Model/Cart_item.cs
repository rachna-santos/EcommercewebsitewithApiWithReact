using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace EcommercewebsitewithApi.Model
{
    public class Cart_item
    {
        [Key]
        public int cart_item { get; set; }
        [ForeignKey("Productveriation")]
        public int veriationId { get; set; }
        public virtual Productveriation Productveriation { get; set; }
        [ForeignKey("Customer")]
        public int Id { get; set; }
        public virtual Customer Customer { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int bill { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public string image { get; set; }


    
    }
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }

}
