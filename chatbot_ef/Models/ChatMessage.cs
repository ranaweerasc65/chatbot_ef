using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class ChatMessage
    {
        [Key]
        public int Message_ID { get; set; }
        public string? Sender { get; set; }
        public string? Content { get; set; }
        public DateTime Timestamp { get; set; }

        public int Session_ID { get; set; } // The foreign key property

        [ForeignKey("Session_ID")]
        public ChatSession? ChatSession { get; set; } // Navigation property for related ChatSession

        public int Platform_ID { get; set; } // The foreign key property

        [ForeignKey("Platform_ID")]
        public Platform? Platform { get; set; } // Navigation property for related Platform
    }
}
