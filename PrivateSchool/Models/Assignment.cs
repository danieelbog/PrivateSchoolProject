using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Assignment
    {
        public int ID { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="You must enter the Assignment Title" )]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Assignment Title must be between 3 and 20 chars")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter the Assignment Descreption")]
        [StringLength(400, MinimumLength = 3, ErrorMessage = "Assignment Descreption must be between 3 and 400 chars")]
        public string Descreption { get; set; }

        [Required(ErrorMessage = "You must pick the deadline for the Assignment")]
        [DataType(DataType.Date)]
        [Display(Name = "Deadline")]
        public DateTime Deadline { get; set; }
        public virtual ICollection<AssignmentPerStudent> AssignmentPerStudent { get; set; }
    }
}