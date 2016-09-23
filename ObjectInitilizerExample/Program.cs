using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitilizerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lstStudents = new List<Student>() {
                new Student() { StudentId = 1, Name = "Sample 1", Age = 10 },
                new Student() { StudentId = 2, Name = "Sample 2", Age = 20 },
                };

            foreach (var item in lstStudents)
            {
                Console.WriteLine("Studnet Id :{0} \t Name :{1}",item.StudentId, item.Name);
            }




        }
    }
}
