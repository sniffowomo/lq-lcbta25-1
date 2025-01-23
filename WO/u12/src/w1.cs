// 1st Execercise 
using System;

namespace u12.src
{
    public class Work1
    {
        // Function 1
        public static void Func1()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World! From .. Press any button to exit");
            Console.ReadKey();
            Console.ResetColor();
        }

        // Printing the first letter in a different color
        public static void Func2()
        {
            string name = "Pusy";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name[0]);
            Console.ResetColor();

            Console.Write(name[1..]);
        }

        // Printing Words in different colors
        public static void Func3()
        {
            Console.Clear();
            // Defining sentence to breakdown 
            string colorWords = "Drink Woman Juices";

            // Defining an array with split words
            string[] words = colorWords.Split(' ');

            // Defining Colors 
            ConsoleColor[] wordColors = {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan,
                ConsoleColor.White
            };

            // Creating instance for random
            Random random = new();

            foreach (string word in words)
            {
                Console.ForegroundColor = wordColors[random.Next(0, wordColors.Length)];
                Console.Write(word + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}