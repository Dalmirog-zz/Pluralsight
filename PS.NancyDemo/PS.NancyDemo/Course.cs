using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS.NancyDemo
{
    public class Course
    {
        public Course(int id, string name,string author)
        {
            Id = id;
            Name = name;
            Author = author;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public static IList<Course> List = new List<Course>(new[]
        {
            new Course(0, "Getting started with Nancy", "Richard Cicerol"),
            new Course(1, "HTTP Fundamentals", "Scott Allen"),
        });

        public static int AddCourse(string name, string author)
        {
            int id = 0;

            if (Course.List.Any())
            {
                id = Course.List.Max(x=> x.Id) + 1;
            }
            else
            {
                id = 0;
            }

            var course = new Course(id, name, author);
            Course.List.Add(course);

            return id;
        }
    }
}