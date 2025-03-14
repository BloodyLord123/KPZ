using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Virus parentVirus = new Virus("Covid-19", "Коронавірус", 30, 0.5);
            Virus child1 = new Virus("Delta", "Мутація", 15, 0.3);
            Virus child2 = new Virus("Omicron", "Мутація", 10, 0.2);
            parentVirus.AddChild(child1);
            parentVirus.AddChild(child2);
            Virus grandChild1 = new Virus("Omicron XBB", "Підваріант", 5, 0.1);
            child2.AddChild(grandChild1);
            Console.WriteLine("Оригінальне сімейство вірусів:");
            parentVirus.ShowInfo();
            Virus clonedVirus = parentVirus.Clone();
            Console.WriteLine("\nКлоноване сімейство вірусів:");
            clonedVirus.ShowInfo();

        }
    }
}
