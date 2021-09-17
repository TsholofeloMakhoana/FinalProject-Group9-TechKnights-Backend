using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SchoolManagementSystem.Models
{
    public class InvoiceData
    {
        [Key]
        public int InvoiceId { get; set; }
        public int StudentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double AmountPaid { get; set; }
        public double Due { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public string DatePaid { get; set; }

    }
}
