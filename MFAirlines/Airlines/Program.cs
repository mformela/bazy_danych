using Airlines.Models;
using Airlines.PersistanceContextEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new SchoolContext())
            {

                foreach (var student in dbContext.Students)
                {
                    Console.WriteLine($"{student.Surname}");
                }




             //var innerCourseStudent =
             //    from course in Course
             //    join student in Student on course.CourseId equals student.CourseId
             //    select new { CourseName = course.Name, Student = student.Surname };

             //   foreach (var course in dbContext.Courses)
             //   {
             //       Console.WriteLine($"{innerCourseStudent}");
             //   }

            
                

            }

            Console.WriteLine("Koniec");
            Console.ReadLine();





        }
        
    }
}
