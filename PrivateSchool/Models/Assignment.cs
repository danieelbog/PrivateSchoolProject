using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Descreption { get; set; }
        public DateTime Deadline { get; set; }
        public virtual ICollection<AssignmentPerStudent> AssignmentPerStudent { get; set; }
    }
}