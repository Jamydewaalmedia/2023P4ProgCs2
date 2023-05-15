using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colors myMainThemeColor = Colors.Purple;

            if (myMainThemeColor == Colors.Purple)
            {
                Console.WriteLine("Dat is mijn kleur!");
            }
            else
            {
                Console.WriteLine("Dit is niet mijn kleur.");
            }
        }
    }
}
