// First excercise 
/* 
Writing some strings for a todo app
*/
using u12.src;

namespace u12.exc
{

    public class Exc1
    {
        public static void Func1()
        {
            Utils.Label1("Excercise 1");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello Excercise 1");
            Console.ResetColor();

            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd TODO");
            Console.WriteLine("[R]emove TODO");
            Console.WriteLine("[E]xit");

            string userChoice = Console.ReadLine();
            System.Console.WriteLine("Entered :" + userChoice);

        }

    }

}