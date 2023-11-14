using System.ComponentModel.DataAnnotations;

namespace chatbot_ef.Models
{
    public class ShopOwner
    {
        [Key]
        public int ShopOwner_ID { get; set; }
        public string? Name { get; set; }
        public string? ContactNumber { get; set; }
        // Navigation property for related shops
        public virtual ICollection<Shop>? Shops { get; set; }

        // Nullable foreign key for ChatSession
        public int ChatSessionId { get; set; }
        public ChatSession? ChatSession { get; set; }
    }
}

