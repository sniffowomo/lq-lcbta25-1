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
            string colorWords = "Drink Woman Juices";
            string[] words = colorWords.Split(' ');
        }
    }
}