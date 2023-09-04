using System;

namespace Grade
{
    class Program
    {
        static void Main()
        {
            string fullName;
            string equivGrade;
            double grade = 0;
            bool isValid = false;

            Console.Write("Full Name: ");
            fullName = Console.ReadLine();
            
            while (!isValid)
            {
                Console.Write("Grade: ");
                if (double.TryParse(Console.ReadLine(), out grade) && grade <= 100)
                    isValid = true;
            }

            if (grade >= 98)
                equivGrade = "1.0";
            else if (grade >= 95)
                equivGrade = "1.25";
            else if (grade >= 92)
                equivGrade = "1.50";
            else if (grade >= 89)
                equivGrade = "1.0";
            else if (grade >= 86)
                equivGrade = "2.0";
            else if (grade >= 83)
                equivGrade = "2.25";
            else if (grade >= 80)
                equivGrade = "2.50";
            else if (grade >= 77)
                equivGrade = "2.75";
            else if (grade == 75)
                equivGrade = "3.00";
            else 
                equivGrade = "5.0";

            Console.WriteLine("{0}, your grade is {1}.", fullName, equivGrade);
        }
    }
}
