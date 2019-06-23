using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int minimunDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimunDamage;
            MaximumDamage = maximumDamage;
        }
    }
}