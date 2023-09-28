using System;

namespace MyActivities_Reveche
{
    public static class Inputs
    {
        public static int GetInt(string message)
        {
            int input;
            while (true)
            {
                Console.Write($"{message} ");
                if (int.TryParse(Console.ReadLine(), out input)) break;
            }

            return input;
        }
        
        public static char GetChar(string message)
        {
            char input;
            while (true)
            {
                Console.Write($"{message} ");
                if (char.TryParse(Console.ReadLine(), out input)) break;
            }

            return input;
        }
    }
}