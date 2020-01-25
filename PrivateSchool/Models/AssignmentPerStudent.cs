using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchool.Models
{
    public enum OralMark
    {
        A, B, C, D, E, F
    }
    public enum TotalMark
    {
        A, B, C, D, E, F
    }
    public class AssignmentPerStudent
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int AssignmentID { get; set; }
        public OralMark? OralMark { get; set; }
        public TotalMark? TotalMark { get; set; }

        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }


    }
}