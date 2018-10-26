using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using C_Sharp_Final_Project.Models;

namespace C_Sharp_Final_Project.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstName="Krusty",LastName="The Clown",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Buttons",LastName="Buttercup",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Crafty",LastName="Crackpot",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Bam Bam",LastName="Baggy Britches",EnrollmentDate=DateTime.Parse("2002-09-01")},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Juggling",Credits=3,},
            new Course{CourseID=4022,Title="Makeup",Credits=3,},
            new Course{CourseID=4041,Title="Riding a Tiny Bike 101",Credits=3,},
            new Course{CourseID=1045,Title="Spraying Flower",Credits=4,},
            new Course{CourseID=3141,Title="Balloon Animals",Credits=4,},
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=5,CourseID=1045},
            new Enrollment{StudentID=5,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}