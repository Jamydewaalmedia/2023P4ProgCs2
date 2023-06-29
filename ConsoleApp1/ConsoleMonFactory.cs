using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void load(string datafile)
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines) {Console.WriteLine(line); }
        }
    }
}
