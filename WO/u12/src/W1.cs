// 1st Execercise 

using Microsoft.VisualBasic;

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

        // Testing multi assigment
        public static void Func2()
        {
            int a = 1, b = 2, c = 3;
            string name = "Booty", lastname = "Dancer";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(name + " " + lastname);
            Console.ResetColor();
        }

        //Var and Implicit and explicit variables
        public static void Func3()
        {
            var name = "Booty"; name = ""; name = "";


        }

    }
}