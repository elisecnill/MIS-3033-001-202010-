using System;
using System.Collections.Generic;
using System.Text;

namespace MoreDifficultStudentExample
{
    class Student
    {
        //if it is private you do not need to do the get and set
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance;

        //ctor tab tab and it will fill in the constructor for you
        public Student()
        {
            SoonerID = -1;
            FirstName = string.Empty;
            LastName = "";
            IsOnProbation = false;
            GPA = 0;
            BursarBalance = 10000;
        }

        public Student(int id, string fName, string lName, double BursarBalance)
        {
            SoonerID = -id;
            FirstName = fName;
            LastName = lName;
            //reason we have to put the two below in both methods is because they are methods
            IsOnProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
            //could also just change one of the bursarBalance names
        }

        public void MakePayment (double amount)
        {
            if(amount > 0)
            {
                BursarBalance = BursarBalance - amount;
            }
            else
            {
                throw new Exception();
            }
        }

        public double CheckBalance()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            string result = $"{FirstName} {LastName} ({SoonerID}) has a {GPA.ToString("N2")} and owes {BursarBalance}";
            

            if(IsOnProbation == true)
            {
                result += "\nIs on Probation.";
            }
            else
            {
                result += "\nIs not on Probation.";
            }
            return result;
        }
    }
}
