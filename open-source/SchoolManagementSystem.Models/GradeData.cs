using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class GradeData
    {
        [Key]
        public int GradeId { get; set; }
        public string Grade { get; set; }
        public string GradePoint { get; set; }
        public decimal TotalFees { get; set; }
        public string GradeDescrption { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}

