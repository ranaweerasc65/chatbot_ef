using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class Shop
    {
        [Key]
        public int Shop_Id { get; set; }
        public string? ShopName { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        [ForeignKey("ShopOwner")] 
        public int ShopOwner_ID { get; set; }
        public ShopOwner? ShopOwner { get; set; } // Navigation property for related ShopOwner

        // Navigation property for related Appointments
        public virtual ICollection<Appoinment>? Appointments { get; set; }
        public virtual ICollection<ChatSessionShop>? ChatSessionShops { get; set; }
        public virtual ICollection<ShopPlatform>? ShopPlatforms { get; set; }
        public ICollection<ShopProduct>? ShopProducts { get; set; }
    }
}

