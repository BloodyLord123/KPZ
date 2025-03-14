using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CharacterDirector director = new CharacterDirector();

            Character hero = director.ConstructHero(new HeroBuilder());
            Character enemy = director.ConstructEnemy(new EnemyBuilder());

            hero.ShowInfo();
            enemy.ShowInfo();
        }
    }
}
