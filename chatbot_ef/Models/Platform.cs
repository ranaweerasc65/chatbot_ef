using System.ComponentModel.DataAnnotations;

namespace chatbot_ef.Models
{
    public class Platform
    {
        [Key]
        public int Platform_ID { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<CustomerPlatform> ? CustomerPlatforms { get; set; }
        public virtual ICollection<ChatMessage> ? ChatMessages { get; set; } // Navigation property for ChatMessages
        public virtual ICollection<ShopPlatform> ? ShopPlatforms { get; set; }
    }
}
