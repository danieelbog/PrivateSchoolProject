using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public virtual ICollection<StudentPerCourse> StudentPerCourse { get; set; }
        public virtual ICollection<TrainerPerCourse> TrainerPerCourse { get; set; }


    }
}