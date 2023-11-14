using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class ChatSession
    {
        [Key]
        public int Session_ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<ChatMessage>? ChatMessages { get; set; }
        public virtual ICollection<ChatSessionShop>? ChatSessionShops { get; set; }
        public ICollection<ShopOwner>? ShopOwners { get; set; }
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
