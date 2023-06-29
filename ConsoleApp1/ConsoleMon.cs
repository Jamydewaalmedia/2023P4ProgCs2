using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        public List<Skill> skills { get; set; }
        public Element weakness { get; set; }



        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
        public ConsoleMon()
        //dit is de default doet niks afblijven mwuah
        {

        }
        internal ConsoleMon(int health, int energy, Element weakness, string name)
        {
            this.health = health;
            this.energy = energy;
            this.weakness = weakness;
            this.name = name;
           
        }
    }
}
