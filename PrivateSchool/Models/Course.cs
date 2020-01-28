using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Course
    {
        public int ID { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="You msut enter Course Title")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Course Title must be between 3 and 20 chars")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="You must define Course Stream")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Course Stream must be between 3 and 20 chars")]
        public string Stream { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "You msut enter Course Type")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Course Type must be between 3 and 20 chars")]
        public string Type { get; set; }

        [Required(ErrorMessage = "You must pick the starting Date for the Course")]
        [DataType(DataType.Date)]
        [Display(Name ="Starting Date")]
        public DateTime StartingDate { get; set; }

        [Required(ErrorMessage ="You must pick the ending Date for the Course")]
        [DataType(DataType.Date)]
        [Display(Name = "Ending Date")]
        public DateTime EndingDate { get; set; }


        public virtual ICollection<StudentPerCourse> StudentPerCourse { get; set; }
        public virtual ICollection<TrainerPerCourse> TrainerPerCourse { get; set; }


    }
}