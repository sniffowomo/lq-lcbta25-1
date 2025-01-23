// Defining non vodi methods 

using Pastel;
using System.Drawing;
using System.Security;

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

        // Adding integer methodws which is no void 
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Checking if a string is considered to be long
        public static bool IsLong(string input)
        {
            return input.Length > 10;
        }

        public static void ExecuteIsLong()
        {
            Utils.Label2("IsLong Method");
            Console.WriteLine("Enter a string: ");
            string? input = Console.ReadLine()?.Trim();
            var resultIsLong = IsLong(input);
            Console.WriteLine($"The string {input.Pastel(Color.YellowGreen)} is {(resultIsLong ? "long" : "short")}");

            Console.WriteLine($"The string {input.Pastel(Color.YellowGreen)} is {(IsLong(input) ? "long" : "short")}");

        }
    }
}