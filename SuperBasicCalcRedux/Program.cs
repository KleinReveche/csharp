using System;

namespace SuperBasicCalcRedux
{
    class Program
    {
        static void Main()
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
                    result = (float) x / y;
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
    }
}
