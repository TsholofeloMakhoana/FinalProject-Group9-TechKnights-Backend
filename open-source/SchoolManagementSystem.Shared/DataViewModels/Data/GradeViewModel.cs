using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Shared
{
    public class GradeViewModel
    {
        public int GradeId { get; set; }
        public string Grade { get; set; }
        public string GradePoint { get; set; }
        public decimal TotalFees { get; set; }

        [StringLength(4, ErrorMessage = "The value cannot exceed 100 characters. ")]
        public string GradeDescrption { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
