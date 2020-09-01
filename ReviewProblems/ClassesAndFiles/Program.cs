using System;
using System.Collections.Generic;

namespace ClassesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student stud1 = new Student(); //constructor
            stud1.name = "Micah";
            stud1.id = 2;
            students.Add(stud1);

            
            Student stud2 = new Student("Elise", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {
                Console.WriteLine(stud);
            }

            DateTime current = DateTime.Now;
            TimeSpan difference = current - stud1.enrollDate;
            Console.WriteLine($"It has been {difference.TotalMilliseconds} since {stud1.name} has enrolled.");
            
            Console.WriteLine($"There are currently {Student.totalStudents} enrolled");


        }
    }
}
