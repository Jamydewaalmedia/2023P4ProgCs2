using System;
using System.IO;

namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText(@"C:\Users\jamyd\Documents\ma\bewijzenmap\periode.1.4\prog\2023P4ProgCs2\SplitOpdracht\stringsplit.txt");

            // Gebruik Split op de eerste regel en scheid deze met ":"
            string[] keyValue = content.Split(':');
            string[] cijfersPerVak = keyValue[1].Split(',');

            Console.WriteLine(keyValue[0]);
            Console.WriteLine(keyValue[1]);
            Console.WriteLine(cijfersPerVak[0]);
            Console.WriteLine(cijfersPerVak[1]);
            Console.WriteLine(cijfersPerVak[2]);
            Console.WriteLine(cijfersPerVak[3]);


        }
    }
}
