﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class ModuleData
    {
        [Key]
        public int ModuleId { get; set; }
        public int GradeId { get; set; }
        public int TeacherId { get; set; }
        public string Module { get; set; }
        public string PassPoint { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
