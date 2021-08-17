using System;


namespace SchoolManagementSystem.Models
{
    public class GenericData
    {
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth {get;set;} 
        public bool IsActive { get; set; }

        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
