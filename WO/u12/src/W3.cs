// Defining non vodi methods 

namespace u12.src
{
    public class Work3
    {
        public static void Func1()
        {
            // Part of this work is continued from exc1
            Utils.Label2("Nonvoid Methods");
            var Result = Sum(10, 20);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}