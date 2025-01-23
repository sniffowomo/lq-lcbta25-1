// Experiments section 

namespace u12.exp
{
    public class Exp1
    {
        //First Letter of word is colored
        public static void FirstLetterColored()
        {
            string name = "Pusy";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name[0]);
            Console.ResetColor();

            Console.Write(name[1..]);
        }

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