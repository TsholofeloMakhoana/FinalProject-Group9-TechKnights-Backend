using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Shared
{
   public class EmailAuditDataViewModel
    {
        [Key]
        public int EmailAuditId { get; set; }
        public string Mailto { get; set; }
        public string MailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string Body { get; set; }
        public string DearName { get; set; }
        public string SentToSystemRole { get; set; }
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
