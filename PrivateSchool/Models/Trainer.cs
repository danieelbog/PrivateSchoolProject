using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Trainer
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter Trainer's First Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 20 chars")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter Trainer's Last Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 20 chars")]
        public string LastName { get; set; }

        [Display(Name = "Subject")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "You must enter Trainer's Sunject Title")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Subject must be between 3 and 20 chars")]
        public string Subject { get; set; }

        public virtual ICollection<TrainerPerCourse> TrainerPerCourse { get; set; }

    }
}