using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyActivities_Reveche
{
    public static class Selector
    {
        public static readonly List<Action> AvailableMethods = new List<Action>();
        public static readonly List<Action> AvailableAltMethods = new List<Action>();

        internal static void Start(int selectedMethod = -1)
        {
            Console.Title = "MyActivities_Reveche";
            if (selectedMethod == -1) DisplayMenu(AvailableMethods);
            else AvailableMethods[selectedMethod].Invoke();
        }

        public static void AltMethods()
        {
            DisplayMenu(AvailableAltMethods, true);
        }

        private static void DisplayMenu(IReadOnlyList<Action> methodList, bool isAlt = false)
        {
            int index;
            var alt = (isAlt) ? "Alt " : "";

            Console.WriteLine($"Welcome to Klein's CSharp {alt}Activities!\n");
            Console.WriteLine($"{alt}Methods: ");

            for (var i = 0; i < methodList.Count; i++)
            {
                var methodName = methodList[i].GetMethodInfo().ToString().Replace("Void ", "");
                Console.WriteLine($"  [{i}] {methodName}");
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write("Select the method to run: ");
                if (int.TryParse(Console.ReadLine(), out index)) break;
            }

            Console.Clear();
            methodList[index].Invoke();
        }
    }
}