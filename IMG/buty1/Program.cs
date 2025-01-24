// File for curling 

using Pastel;
using System.Drawing;

namespace buty1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var colors = new[] { Color.Red, Color.AliceBlue, Color.BlanchedAlmond, Color.BlueViolet };
            foreach (var color in colors)
            {
                Console.WriteLine("Hello World!".Pastel(color));
            }

        }
    }
}