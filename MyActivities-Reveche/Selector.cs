using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyActivities_Reveche
{
    class Selector
    {
        public static List<Action> availableMethods = new List<Action>();
        public static List<Action> availableAltMethods = new List<Action>();

        internal static void Start(int selectedMethod = -1)
        {
            Console.Title = "MyActivities_Reveche";
            if (selectedMethod == -1) DisplayMenu(availableMethods);
            else 
            {
                availableMethods[selectedMethod].Invoke();
            }
        }

        public static void AltMethods()
        {
            DisplayMenu(availableAltMethods, true);
        }

        private static void DisplayMenu(List<Action> methodList, bool isAlt = false)
        {
            int index = 0;
            bool indexIsValid = false;
            string alt = (isAlt) ? "Alt " : "";

            Console.WriteLine($"Welcome to Klein's CSharp {alt}Activities!\n");
            Console.WriteLine($"{alt}Methods: ");

            for (int i = 0; i < methodList.Count; i++)
            {
                string methodName = methodList[i].GetMethodInfo().ToString().Replace("Void ", "");
                Console.WriteLine($"  [{i}] {methodName}");
            }

            Console.WriteLine();

            while (!indexIsValid)
            {
                Console.Write("Select the method to run: ");
                if (int.TryParse(Console.ReadLine(), out index))
                {
                    indexIsValid = true;
                }
            }

            Console.Clear();
            methodList[index].Invoke();
        }
    }
}