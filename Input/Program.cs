using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;

            Console.Write("What's your first name? ");
            firstName = Console.ReadLine();
            Console.Write("What's your last name? ");
            lastName = Console.ReadLine();
            Console.Write("What's your age? ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hello " + firstName + " " + lastName + "!");
            Console.WriteLine("Your age is " + age);
        }
    }
}
