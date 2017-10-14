using Airlines.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.PersistanceContextEF
{
    class SchoolInitializer : DropCreateDatabaseAlways<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            IList<Student> defaultStudents = new List<Student>();
            defaultStudents.Add(new Student()
            {
                Name = "Maciej",
                Surname = "Gromelski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Jarosław",
                Surname = "Olszewski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Katarzyna",
                Surname = "Nagel",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Jakub",
                Surname = "Lorenc",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Artur",
                Surname = "Gruszka",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Jakub",
                Surname = "Tor",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Marta",
                Surname = "Formela",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Łukasz",
                Surname = "Rachwał",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Patryk",
                Surname = "Kamiński",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Jarosław",
                Surname = "Holender",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Damian",
                Surname = "Kalicki",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Mariusz",
                Surname = "Murawski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Wiesław",
                Surname = "Romanowski",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Kamil",
                Surname = "Pawlak",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Karol",
                Surname = "Kobiela",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Łukasz",
                Surname = "Mrugała",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Michał",
                Surname = "Wagner",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });
            defaultStudents.Add(new Student()
            {
                Name = "Adrian",
                Surname = "Stanek",
                DateOfBirth = DateTime.Now.AddYears(-19),
                PESEL = Guid.NewGuid().ToString(),
            });



            var course = new Course()

            {
                CourseId = 1,
                Name = ".NET Starter",
                Code = "dotNet150",
                Description = ".NET Course by Software Development Academy",
                Students = defaultStudents.ToList()
            };




            foreach (Student student in defaultStudents)

                context.Students.Add(student);
            context.Courses.Add(course);
            base.Seed(context);


        }

           
            

        

   



    }
}
