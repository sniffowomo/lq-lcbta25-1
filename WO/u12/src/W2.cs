//Contiuation from L28 
namespace u12.src
{
    public class Work2
    {
        public static void Func1()
        {
            // Part of this work is continued from exc1
            Utils.Label1("Method");

            var userChoice = Console.ReadLine();

            if (userChoice == "S")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Seleted Option: See TODOs");
                Console.ResetColor();
            }
            else if (userChoice == "A")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Seleted Option: Add TODO");
                Console.ResetColor();
            }
            else if (userChoice == "R")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Seleted Option: Remove TODO");
                Console.ResetColor();
            }
            else if (userChoice == "E")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Seleted Option: Exit");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Choice");
                Console.ResetColor();
            }
        }

    }
}