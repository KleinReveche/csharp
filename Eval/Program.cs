using System;

namespace Eval
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 11, c = 12;

            Console.WriteLine("a > b; The result of expression is: {0}", a > b);
            Console.WriteLine("!(a >= b); The result of expression is: {0}", !(a >= b));
            Console.WriteLine("(a * b) > 10; The result of expression is: {0}", (a * b) > 10);
            Console.WriteLine("!((a+b+c) == (a * b)); The result of expression is: {0}", !((a + b + c) == (a * b)));
            Console.WriteLine("((a <= b) && (c >= 10)) || (c > (b * c)); The result of expression is: {0}", ((a <= b) && (c >= 10)) || (c > (b * c)));
        }
    }
}