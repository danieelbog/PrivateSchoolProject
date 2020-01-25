using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<TrainerPerCourse> TrainerPerCourse { get; set; }

    }
}