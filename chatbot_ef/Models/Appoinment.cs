using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chatbot_ef.Models
{
    public class Appoinment
    {
        [Key]
        public int Appointment_ID { get; set; }

        public DateTime Time { get; set; }
        // Foreign Key for Customer
        [ForeignKey("Customer")]
        public int Customer_ID { get; set; }
        public Customer? Customer { get; set; } // Navigation property for the related customer

        public int Shop_Id { get; set; } // The foreign key property

        [ForeignKey("Shop_Id")] // Correctly reference the foreign key property
        public Shop? Shop { get; set; } // Navigation property for related Shop

    }
}
