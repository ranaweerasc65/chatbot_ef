using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class ChatSessionShop
    {
        [Key]
        public int ChatSessionShopId { get; set; }

        public int ChatSessionId { get; set; }
        [ForeignKey("ChatSessionId")]
        public ChatSession? ChatSession { get; set; }

        public int Shop_Id { get; set; }
        [ForeignKey("Shop_Id")]
        public Shop? Shop { get; set; }
    }
}
