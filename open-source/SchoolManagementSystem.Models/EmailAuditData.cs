using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class EmailAuditData
    {
        public int EmailAuditId { get; set; }
        public string Message { get; set; }
        public string Mailto { get; set; }
        public string MailToFullnames { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
