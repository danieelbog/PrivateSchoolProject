using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Fees { get; set; }
        public virtual ICollection<StudentPerCourse> StudentPerCourse { get; set; }
        public virtual ICollection<AssignmentPerStudent> AssignmentPerStudent { get; set; }

    }
}