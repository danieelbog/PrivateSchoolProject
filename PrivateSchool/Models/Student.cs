using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="You must enter Student's First Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="First Name must be between 3 and 20 chars")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter Student's Last Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 20 chars")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1000,2500, ErrorMessage = "Student Fees must be between 1000 and 2500")]
        public decimal Fees { get; set; }
        public virtual ICollection<StudentPerCourse> StudentPerCourse { get; set; }
        public virtual ICollection<AssignmentPerStudent> AssignmentPerStudent { get; set; }

    }
}