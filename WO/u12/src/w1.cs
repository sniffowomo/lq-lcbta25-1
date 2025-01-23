// 1st Execercise 
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

        public static void Func2()
        {
            string name = "Pusy";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(name[0]);

            Console.ResetColor();

        }
    }
}