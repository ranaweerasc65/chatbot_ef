using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace chatbot_ef.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int ContactNumber { get; set; }
        // Navigation property to represent the list of appointments
        public virtual ICollection<Appoinment> ? Appointments { get; set; }
        public virtual ICollection<CustomerPlatform>? CustomerPlatforms { get; set; }
        public ICollection<ChatSession>? ChatSessions { get; set; }

    }
}
