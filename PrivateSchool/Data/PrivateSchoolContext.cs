using PrivateSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrivateSchool.Data
{
    public class PrivateSchoolContext : DbContext
    {
        public PrivateSchoolContext() : base("PrivateSchoolContext") // TODO connection string at Config
        { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<TrainerPerCourse> TrainerPerCourses { get; set; }
        public DbSet<AssignmentPerStudent> AssignmentPerStudents  { get; set; }
        public DbSet<StudentPerCourse> StudentPerCourses { get; set; }


    }
}