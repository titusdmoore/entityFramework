using EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework {
    class Program {
        static void Main(string[] args) {

            // Assaignment Create a class with data for majors with id, description, and min SAT
            // Add more students, test some queries with where clauses

            var context = new AppDbContext();
            var coursesArr = new Course[] {
                new Course("Intro to Linux", "Sutit Eroom", 24, "Cyber Security"),
                new Course("Boom", "Jerritte Couture", 13, "Rocket Science"),
                new Course("Game Theory", "Sutit Eroom", 45, "Esports"),
                new Course("English Literature 101", "Giddeons Leon", 24, "Literature"),
                new Course("Esports Business", "Sutit Eroom", 24, "Esports"),
                new Course("Kali Linux", "Sutit Eroom", 24, "Cyber Security"),
            };
            foreach (var course in coursesArr) {
                context.Courses.Add(course);
            }

            //var studentsArr = new Student[] {
            //    new Student("J.", "Bird", 1100, 2.8, true, "Esports"),
            //    new Student("P.", "Star", 650, 1.7, false, "Public Speaking"),
            //    new Student("J.", "Neutron", 2400, 5.0, true, "Theater"),
            //    new Student("T.", "Turner", 1300, 2.5, true, "Golf Science"),
            //    new Student("S.", "Rogers", 1000, 4.6, false, "Socialogy")
            //};

            //foreach (var student in studentsArr) {
            //    context.Students.Add(student);
            //}

            // Not Working code till line 23
            //List<Student> students = new List<Student>().AddRange(
            //    new Student("J.", "Bird", 1100, 2.8, true, "Esports"),
            //    new Student("P.", "Star", 650, 1.7, false, "Public Speaking"),
            //    new Student("J.", "Neutron", 2400, 5.0, true, "Theater"),
            //    new Student("T.", "Turner", 1300, 2.5, true, "Golf Science"),
            //    new Student("S.", "Rogers", 1000, 4.6, false, "Socialogy")
            //    );

            context.SaveChanges();
            //var major1 = new Major();
            //major1.Id = 0;
            //major1.Description = "Nursing";
            //major1.MinSat = 1100;
            //var major2 = new Major();
            //major2.Id = 0;
            //major2.Description = "Accounting";
            //major2.MinSat = 1300;
            //var major3 = new Major();
            //major3.Id = 0;
            //major3.Description = "Public Speaking";
            //major3.MinSat = 5;
            //var major4 = new Major();
            //major4.Id = 0;
            //major4.Description = "Golf Science";
            //major4.MinSat = 1400;
            //var major5 = new Major();
            //major5.Id = 0;
            //major5.Description = "Esports Managment";
            //major5.MinSat = 800;
            //var major6 = new Major();
            //major6.Id = 0;
            //major6.Description = "Socialogy";
            //major6.MinSat = 800;
            //var major7 = new Major();
            //major7.Id = 0;
            //major7.Description = "History";
            //major7.MinSat = 900;
            //var major8 = new Major();
            //major8.Id = 0;
            //major8.Description = "Political Science";
            //major8.MinSat = 1000;
            //var major9 = new Major();
            //major9.Id = 0;
            //major9.Description = "Theater";
            //major9.MinSat = 200;
            //var major10 = new Major();
            //major10.Id = 0;
            //major10.Description = "Computer Science";
            //major10.MinSat = 1500;

            //context.Majors.Add(major1);
            //context.Majors.Add(major2);
            //context.Majors.Add(major3);
            //context.Majors.Add(major4);
            //context.Majors.Add(major5);
            //context.Majors.Add(major6);
            //context.Majors.Add(major7);
            //context.Majors.Add(major8);
            //context.Majors.Add(major9);
            //context.Majors.Add(major10);


            //var major = context.Majors.Find(5);
            //if (major == null) {
            //    throw new Exception("Not Found!");
            //}
            //context.Remove(major);

            //var major = context.Majors.Find(3);
            //// Better way to check because program ends if true and will run file normally (not in big block) if false
            //if (major == null) {
            //    throw new Exception("Not Found!");
            //}
            //major.Description = "Literature";
            //major.MinSat = 900;

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Biology";
            //major.MinSat = 1100;

            //context.Majors.Add(major);




            //var students = context.Students.Where(s => s.GPA >= 3.0).OrderBy(s => s.lastName).ToArray();
            //var studentsDesc = context.Students.OrderByDescending(s => s.lastName).ToArray();
            //var students = context.Students
            //    .Where(s => s.Major.Description != null)
            //    .OrderBy(s => s.Major.Description)            
            //    .ToList();

            //foreach (var student in students) {
                
            //    Console.WriteLine(student);
            //}
            //var studentAvgSAT = context.Students
            //    .Average(s => s.SAT);
            //Console.WriteLine(studentAvgSAT);
            //foreach (var student in students) {
            //    Console.WriteLine();
            //}

            //var majors = context.Majors.OrderBy(s => s.Description);

            //foreach (var major in majors) {
            //    Console.WriteLine(major);
            //}
            //var genStudies = context.Majors.Find(1).ToString();
            //Console.WriteLine(genStudies);
        }
    }
}
