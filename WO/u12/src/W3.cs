// Defining non vodi methods 

using Pastel;
using System.Drawing;

namespace u12.src
{
    public class Work3
    {
        public static void Func1()
        {
            // Part of this work is continued from exc1
            Utils.Label2("Nonvoid Methods");
            var Result = Sum(10, 20);
            Console.WriteLine($"Sum of {10.ToString().Pastel(Color.DarkCyan)} and {20.ToString().Pastel(Color.WhiteSmoke)} is {Result}");
            Console.WriteLine($"Press {"ENTER".Pastel(Color.FromArgb(165, 229, 250))} to continue");
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}