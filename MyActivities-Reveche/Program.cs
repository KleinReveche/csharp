using System;

namespace MyActivities_Reveche
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic();
            //Grade();
            //HighestLowest();
            //ForLoop();
            //ForLoopSortedNumbers();
            ForLoopOddEven();

            // These are extra alternative implementations of the activities
            //Alt.HighestLowestArrays();
            //Alt.HighestLowestLists();
            //Alt.ForLoopWithCount();
            //Alt.ForLoopSortedNumbersSafe();
            //Alt.ForLoopOddEven2();

        }
        static void Arithmetic()
        {
            int x, y;
            float result = 0;
            char optr;
            string optrResult = "";
            bool isValid = true;

            Console.WriteLine("Welcome to SuperBasicCalculatorRedux!");
            Console.WriteLine("Enter your number to get started. \n");

            Console.Write("Enter number 1: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter arithmetic operator: ");
            optr = Convert.ToChar(Console.ReadLine());

            switch (optr)
            {
                case '+':
                    result = x + y;
                    optrResult = "sum";
                    break;
                case '-':
                    result = x - y;
                    optrResult = "difference";
                    break;
                case '*':
                    result = x * y;
                    optrResult = "product";
                    break;
                case '/':
                    result = (float)x / y;
                    optrResult = "quotient";
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (isValid)
                Console.WriteLine("\nThe {0} of {1} {2} {3} is {4}", optrResult, x, optr, y, result);
            else
                Console.WriteLine("The operator is invalid.");
        }

        static void Grade()
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

        static void HighestLowest()
        {
            // Basic
            int a, b, c, d, e;
            int max = 0, min = 0;

            Console.WriteLine("Input 5 Numbers:");
            Console.Write("> ");
            a = int.Parse(Console.ReadLine());
            Console.Write("> ");
            b = int.Parse(Console.ReadLine());
            Console.Write("> ");
            c = int.Parse(Console.ReadLine());
            Console.Write("> ");
            d = int.Parse(Console.ReadLine());
            Console.Write("> ");
            e = int.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e) max = a;
            if (b >= c && b >= d && b >= e && b >= a) max = b;
            if (c >= d && c >= e && c >= a && c >= b) max = c;
            if (d >= e && d >= a && d >= b && d >= c) max = d;
            if (e >= a && e >= b && e >= c && d >= b) max = e;

            if (a <= b && a <= c && a <= d && a <= e) min = a;
            if (b <= c && b <= d && b <= e && b <= a) min = b;
            if (c <= d && c <= e && c <= a && c <= b) min = c;
            if (d <= e && d <= a && d <= b && d <= c) min = d;
            if (e <= a && e <= b && e <= c && d <= b) min = e;

            Console.WriteLine("The highest value is {0}.", max);
            Console.WriteLine("The lowest value is {0}.", min);
        }

        static void ForLoop()
        {
            int count = 5, sum = 0;

            Console.WriteLine("Enter {0} Numbers:", count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("> ");
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe Average is {0}", (float) sum / count);
        }

        static void ForLoopSortedNumbers()
        {
            int count;
            string order;

            Console.Write("Enter number of loop/s: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("In what order would you like to display? [asc/desc]: ");
            order = Console.ReadLine().ToLower();

            if (order == "asc")
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write((i < count) ? i + ", " : i.ToString());
                }
                Console.WriteLine();
            }
            else if (order == "desc")
            {
                for (int i = count; i > 0; i--)
                {
                    Console.Write((i > 1) ? i + ", " : i.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid Sort Direction.");
            }
        }

        static void ForLoopOddEven()
        {
            int n, number, evenCount = 0, oddCount = 0, sumEven = 0, sumOdd = 0;

            Console.WriteLine("Welcome to my Odd-Even-inator!\n");
            Console.Write("Enter n times: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEnter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("> ");
                number = int.Parse(Console.ReadLine());

                if (number < 1)
                {
                    Console.Write("[Error: Enter a number more than 0] > ");
                    number = int.Parse(Console.ReadLine());
                }

                if (number % 2 == 0)
                {
                    evenCount++;
                    sumEven += number;
                }
                else 
                {
                    oddCount++;
                    sumOdd += number;
                }
            }

            Console.WriteLine($"\nThe # of even numbers is {evenCount}");
            Console.WriteLine($"The sum of even numbers is {sumEven}");
            Console.WriteLine($"The # of odd numbers is {oddCount}");
            Console.WriteLine($"The sum of odd numbers is {sumOdd}");

        }
    }
}
