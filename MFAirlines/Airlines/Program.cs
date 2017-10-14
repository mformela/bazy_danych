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
            var dbContext = new SchoolContext();
            foreach (var student in dbContext.Students)
            {
                Console.WriteLine($"{student.Surname}");
            }
            Console.ReadLine();
        }
    }
}
