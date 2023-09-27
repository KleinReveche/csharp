using System;
// ReSharper disable JoinDeclarationAndInitializer, AssignNullToNotNullAttribute, SuggestVarOrType_BuiltInTypes

namespace MyActivities_Reveche
{
    public static partial class Program
    {
        private static void Arithmetic()
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

        private static void Grade()
        {
            string fullName;
            string equivGrade;
            double grade;

            Console.Write("Full Name: ");
            fullName = Console.ReadLine();

            while (true)
            {
                Console.Write("Grade: ");
                if (double.TryParse(Console.ReadLine(), out grade) && grade <= 100) break;
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
            else if (grade >= 76)
                equivGrade = "2.75";
            else if (Math.Abs(grade - 75) < 76)
                equivGrade = "3.00";
            else
                equivGrade = "5.0";

            Console.WriteLine("{0}, your grade is {1}.", fullName, equivGrade);
        }

        private static void HighestLowest()
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

        private static void ForLoop()
        {
            int count = 5, sum = 0;

            Console.WriteLine("Enter {0} Numbers:", count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("> ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("\nThe Average is {0}", (float)sum / count);
        }

        private static void ForLoopSortedNumbers()
        {
            int count;
            string order;

            Console.Write("Enter number of loop/s: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("In what order would you like to display? [asc/desc]: ");
            order = Console.ReadLine()?.ToLower();

            switch (order)
            {
                case "asc":
                {
                    for (int i = 1; i <= count; i++)
                    {
                        Console.Write((i < count) ? i + ", " : i.ToString());
                    }

                    Console.WriteLine();
                    break;
                }
                case "desc":
                {
                    for (int i = count; i > 0; i--)
                    {
                        Console.Write((i > 1) ? i + ", " : i.ToString());
                    }

                    Console.WriteLine();
                    break;
                }
                default:
                    Console.WriteLine("Invalid Sort Direction.");
                    break;
            }
        }

        private static void ForLoopOddEven()
        {
            int n, evenCount = 0, oddCount = 0, sumEven = 0, sumOdd = 0;
            string oddNumbers = "", evenNumbers = "";

            Console.WriteLine("Welcome to my Odd-Even-inator!\n");
            Console.Write("Enter n times: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEnter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("> ");
                var number = int.Parse(Console.ReadLine());

                if (number < 1)
                {
                    Console.Write("[Error: Enter a number more than 0] > ");
                    number = int.Parse(Console.ReadLine());
                }

                if (number % 2 == 0)
                {
                    evenCount++;
                    sumEven += number;
                    evenNumbers += $"{number + (((evenCount + oddCount) < n - 1) ? ", " : "")}";
                }
                else
                {
                    oddCount++;
                    sumOdd += number;
                    oddNumbers += $"{number + (((evenCount + oddCount) < n - 1) ? ", " : "")}";
                }
            }

            Console.WriteLine($"\nThe # of even numbers is {evenCount}, which is [{evenNumbers}]");
            Console.WriteLine($"The sum of even numbers is {sumEven}");
            Console.WriteLine($"The # of odd numbers is {oddCount}, which is [{oddNumbers}]");
            Console.WriteLine($"The sum of odd numbers is {sumOdd}\n");
        }

        private static void WhileLoopSortedNumbers()
        {
            int i, count;
            string order;

            Console.Write("Enter number of loop/s: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("In what order would you like to display? [asc/desc]: ");
            order = Console.ReadLine()?.ToLower();

            switch (order)
            {
                case "asc":
                    i = 1;
                    while (i <= count)
                    {
                        Console.Write((i < count) ? i + ", " : i.ToString());
                        i++;
                    }

                    Console.WriteLine();
                    break;
                case "desc":
                    i = count;
                    while (i > 0)
                    {
                        Console.Write((i > 1) ? i + ", " : i.ToString());
                        i++;
                    }

                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Sort Direction.");
                    break;
            }
        }

        private static void DoWhileLoopSortedNumbers()
        {
            int i, count;
            string order;

            Console.Write("Enter number of loop/s: ");
            count = int.Parse(Console.ReadLine());
            Console.Write("In what order would you like to display? [asc/desc]: ");
            order = Console.ReadLine()?.ToLower();

            switch (order)
            {
                case "asc":
                    i = 1;
                    do
                    {
                        Console.Write((i < count) ? i + ", " : i.ToString());
                        i++;
                    } while (i <= count);

                    Console.WriteLine();
                    break;
                case "desc":
                    i = count;
                    do
                    {
                        Console.Write((i > 1) ? i + ", " : i.ToString());
                        i--;
                    } while (i > 0);

                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Sort Direction.");
                    break;
            }
        }

        private static void QuizTwoLoops()
        {
            var desc = "";
            var oddEvenResult = "";

            Console.WriteLine("Numberino Machino\n");
            Console.Write("Enter a number: ");
            var num = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine();
            for (var i = 1; i <= num; i++)
            {
                Console.Write($"{i} ");
                if (i != num) desc = $"{i} {desc}";
            }

            Console.Write($"{desc}\n\n");

            for (var i = 1; i <= num * 2; i++)
                if (i % 2 == 0)
                    oddEvenResult += ((i == 2) ? "" : " ") + (i - 1 + i);

            Console.WriteLine(oddEvenResult);
            Console.WriteLine();
        }

        private static void BmiCalculator()
        {
            Console.WriteLine("Welcome to Dr. Lester Papadopoulos' Wonderful BMI Calculator!");

            while (true)
            {
                double height, weight;

                Console.WriteLine();

                while (true)
                {
                    Console.Write("Input your height (feet.inches): ");
                    if (double.TryParse(Console.ReadLine(), out height)) break;
                }

                while (true)
                {
                    Console.Write("Input your weight (kg): ");
                    if (double.TryParse(Console.ReadLine(), out weight)) break;
                }

                var bmi = weight * 2.2 / Math.Pow(height * 12, 2) * 703;

                Console.WriteLine($"\nYour BMI is {bmi:N2}.");
                Console.Write("Your status is ");

                if (bmi < 18.5) Console.Write("Underweight.\n");
                else if (bmi < 25) Console.Write("Normal.\n");
                else if (bmi < 40) Console.Write("Overweight.\n");
                else Console.Write("Obese.\n");

                Console.WriteLine("\nPress N if you don't want to continue...");
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.N) break;

                Console.Clear();
            }
        }
    }
}