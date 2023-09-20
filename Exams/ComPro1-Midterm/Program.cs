using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPro1_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
        }
        static void ProblemOne()
        {
            Console.Write("Enter your score: ");
            var score = int.Parse(Console.ReadLine());

            if (score < 0) Console.WriteLine("No numbers are entered except 0.");
            else if (score >= 60) Console.WriteLine("You pass the exam.");
            else Console.WriteLine("You didn't pass the exam");
        }
    }
}
