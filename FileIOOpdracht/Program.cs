using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] content = File.ReadAllLines(@"C:\Users\jamyd\Documents\ma\bewijzenmap\periode.1.4\prog\2023P4ProgCs2\FileIOOpdracht\leesdezefile.txt");
            
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
        }
    }
}
