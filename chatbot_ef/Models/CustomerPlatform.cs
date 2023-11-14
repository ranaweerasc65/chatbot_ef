using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class CustomerPlatform
    {
        [Key]
        public int CustomerPlatform_ID { get; set; }

        [ForeignKey("Customer")]
        public int Customer_ID { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("Platform")]
        public int Platform_ID { get; set; }
        public Platform?  Platform { get; set; }
    }
}

