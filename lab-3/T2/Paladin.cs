using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Paladin : Hero
    {
        public Paladin(string name) : base(name) { }

        public override string GetInfo()
        {
            return $"{Name} (Клас: Paladin)";
        }
    }
}
