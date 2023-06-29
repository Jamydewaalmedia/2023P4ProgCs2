using System;
using System.IO;

namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\jamyd\\Documents\\ma\\bewijzenmap\\periode.1.4\\prog\\2023P4ProgCs2"; 

            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] items = dir.GetFiles();


            for (int i = 0; i < items.Length; i++)
            {
                
                Console.WriteLine(items[i].Name);
            }

            foreach (DirectoryInfo sub in dir.GetDirectories())
            {
                Console.WriteLine(sub.Name);
            }
        }
    }
}
