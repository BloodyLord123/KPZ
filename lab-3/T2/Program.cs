using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Hero warrior = new Warrior("Тралл");
            Hero mage = new Mage("Джайна");
            Hero paladin = new Paladin("Артес");
            warrior = new Armor(warrior); 
            warrior = new Weapon(warrior); 
            mage = new Armor(mage);
            mage = new Artifact(mage);    
            paladin = new Armor(paladin); 
            paladin = new Weapon(paladin); 
            Console.WriteLine(warrior.GetInfo());
            Console.WriteLine(mage.GetInfo());
            Console.WriteLine(paladin.GetInfo());
        }
    }
}
