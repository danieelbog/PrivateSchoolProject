using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class StudentPerCourse
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}