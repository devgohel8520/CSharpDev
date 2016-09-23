﻿using System;
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
            ////Example 1: Object Initilizer

            Student student = new Student() { StudentId = 1, Name = "Sample 1", Age = 20 };
            Console.WriteLine("Student Id:{0} \t Name: {1}", student.StudentId, student.Name);

            //End Example 1

            //Example 2: Collection Initilizer

            //List<Student> lstStudents = new List<Student>() {
            //    new Student() { StudentId = 1, Name = "Sample 1", Age = 10 },
            //    new Student() { StudentId = 2, Name = "Sample 2", Age = 20 },
            //    };

            //foreach (var item in lstStudents)
            //{
            //    Console.WriteLine("Studnet Id :{0} \t Name :{1}",item.StudentId, item.Name);
            //}

            //End Example 2




        }
    }
}
