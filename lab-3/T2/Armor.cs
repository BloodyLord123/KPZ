using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Armor : HeroDecorator
    {
        public Armor(Hero hero) : base(hero) { }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, Інвентар: Одяг";
        }
    }
}
