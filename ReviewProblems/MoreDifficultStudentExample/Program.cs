using System;

namespace MoreDifficultStudentExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number.");
            double x = Convert.ToDouble(Console.ReadLine());
            //create an instance of the class student
            Student myStudent = new Student(5,"Elise", "Nill", 100000);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);

            try
            {
                myStudent.MakePayment(-500);
                Console.WriteLine(myStudent);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(myStudent);

        }
    }
}
