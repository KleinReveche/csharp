using System;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static void Main(string[] args)
        {
            FizzBuzz1();
        }

        private static void FizzBuzz1()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void FizzBuzz2()
        {
            for (var i = 1; i <= 100; i++)
            {
                var str = "";  
                
                if (i % 3 == 0)  
                    str += "Fizz";  
                if (i % 5 == 0) 
                    str += "Buzz";  
                if (str.Length == 0)  
                    str = i.ToString();  
                
                Console.WriteLine(str);  
            }   
        }
    }
}
