using PrivateSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrivateSchool.Data
{
    public class PrivateSchoolInitializer : DropCreateDatabaseIfModelChanges<PrivateSchoolContext>
    {
        protected override void Seed(PrivateSchoolContext context)
        {           
            // Random generation for Names and Subjects Arrays
            Random random = new Random();
            string[] firstNames = { "Daniel", "Nikos", "George", "Takis", "Maria", "Dimitra", "Aria", "Tereza", "Iwanna", "Volfkan", "Matahari", "Gregory", "John", "Argyris", "Periklis" };
            string[] lastNames = { "Johnson", "Trump", "McGregor", "Thompson", "Obama", "Clinton", "DevOps", "Wick", "Pagidas", "Aidinopoulos" };
            string[] subjects = { "Math", "Physics", "Java", "C#.", "FrontEnd", "JavaScript", "Anguilar", "Cobolt", "Python", "C++", "HTML", "CSS" };
            string[] Ctitles = { "BC9", "BC10", "BC8" };
            string[] streams = { "Java", "C#", "FrontEnd", "JavaScript", "Anguilar", "Cobolt", "Python", "C++", "HTML", "CSS" };
            string[] types = { "Full Time", "Part Time", "No Time", "Prepare To Die Edition" };
            string[] Atitles = { "As-1", "As-2", "As-3", "As-4", "As-5" };
            string[] desccriptions = { "Desc1", "Desc2", "Desc3", "Desc4", "Desc5", "Desc6" };

            var trainers = new List<Trainer>
            {
                new Trainer{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], Subject = subjects[random.Next(0, subjects.Length)] },
                new Trainer{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], Subject = subjects[random.Next(0, subjects.Length)] },
                new Trainer{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], Subject = subjects[random.Next(0, subjects.Length)] }

            };

            trainers.ForEach(t => context.Trainers.Add(t));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},
                new Student{FirstName = firstNames[random.Next(0, firstNames.Length)], LastName = lastNames[random.Next(0, lastNames.Length)], DateOfBirth=DateTime.Parse("1995-09-01"), Fees = random.Next(1000,2000)},

            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{Title = Ctitles[random.Next(0, Ctitles.Length)], Stream = streams[random.Next(0, streams.Length)], Type = types[random.Next(0, types.Length)], StartingDate=DateTime.Parse("2019-09-01"),EndingDate=DateTime.Parse("2020-09-01") },
                new Course{Title = Ctitles[random.Next(0, Ctitles.Length)], Stream = streams[random.Next(0, streams.Length)], Type = types[random.Next(0, types.Length)], StartingDate=DateTime.Parse("2019-06-01"),EndingDate=DateTime.Parse("2020-06-01") },
                new Course{Title = Ctitles[random.Next(0, Ctitles.Length)], Stream = streams[random.Next(0, streams.Length)], Type = types[random.Next(0, types.Length)], StartingDate=DateTime.Parse("2019-04-01"),EndingDate=DateTime.Parse("2020-04-01") },

            };

            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var assignments = new List<Assignment>
            {
                new Assignment{Title = Atitles[random.Next(0, Atitles.Length)], Descreption = desccriptions[random.Next(0, desccriptions.Length)], Deadline =DateTime.Parse("2019-09-01")},
                new Assignment{Title = Atitles[random.Next(0, Atitles.Length)], Descreption = desccriptions[random.Next(0, desccriptions.Length)], Deadline =DateTime.Parse("2019-11-01")},
                new Assignment{Title = Atitles[random.Next(0, Atitles.Length)], Descreption = desccriptions[random.Next(0, desccriptions.Length)], Deadline =DateTime.Parse("2020-1-11")},
            };

            assignments.ForEach(a => context.Assignments.Add(a));
            context.SaveChanges();

        }
        
    }
}