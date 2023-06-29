using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void load(string datafile)
        {
            
            string[] lines = File.ReadAllLines(datafile);
            
            foreach (string line in lines)
            {
                string[] consoleMonData;
                Console.WriteLine(line);
                string[] typeSplit = line.Split('|');
                consoleMonData = typeSplit[0].Split(",");
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.health = int.Parse(consoleMonData[2]);
                dataMon.name = consoleMonData[0];
                dataMon.energy= int.Parse(consoleMonData[4]);
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.energy);
                Console.WriteLine(dataMon.health);



            }

        }
        internal List<ConsoleMon> LoadJson(string datafile)
        {
            string jason = File.ReadAllText(datafile);
            Console.WriteLine(jason);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(jason);
            Console.WriteLine(templates[0].name);
            return templates;
            
        }
        internal Skill CopySkill(Skill copyFrom)
        {
            var copyResult = new Skill( copyFrom.damage,copyFrom.energyCost,copyFrom.name,copyFrom.element);


            return copyResult;
        }
        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health,copyFrom.energy,copyFrom.weakness,copyFrom.name);
            copyResult.skills = new List<Skill>();
            foreach (Skill skil in copyFrom.skills)
            {
                Skill copy = CopySkill(skil);
                copyResult.skills.Add(copy);
            }
            return copyResult;

        }
    }
}
