// Experiments section 

using u12.src;

namespace u12.exp
{
    public class Exp1
    {
        //First Letter of word is colored
        public static void FirstLetterColored()
        {
            Utils.Label1("First Letter Colored Program");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[?] Enter Word whose caps you want colored : ");
            Console.ResetColor();
            string word = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(word[0]);
            Console.ResetColor();

            Console.Write(word[1..]);
        }

        public static void SentenceColored()
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