using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class TrainerPerCourse
    {
        public int ID { get; set; }
        public int TrainerID { get; set; }
        public int CourseID { get; set; }

        public virtual Trainer Trainer { get; set; }
        public virtual Course Course { get; set; }

    }
}