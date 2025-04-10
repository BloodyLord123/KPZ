using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero _hero;

        public HeroDecorator(Hero hero) : base(hero.Name)
        {
            _hero = hero;
        }

        public override string GetInfo()
        {
            return _hero.GetInfo();
        }
    }
}
