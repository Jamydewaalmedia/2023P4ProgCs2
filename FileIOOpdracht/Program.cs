using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText(@"C:\Users\jamyd\Documents\ma\bewijzenmap\periode.1.4\prog\2023P4ProgCs2\FileIOOpdracht\bin\Debug\net6.0\output\leesdezefile.txt", "het is ker");
            string[] content = File.ReadAllLines(@"C:\Users\jamyd\Documents\ma\bewijzenmap\periode.1.4\prog\2023P4ProgCs2\FileIOOpdracht\bin\Debug\net6.0\output\leesdezefile.txt");
            Directory.CreateDirectory("output");

            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);

            }

           

        }

    }
}
