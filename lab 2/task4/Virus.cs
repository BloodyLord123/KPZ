using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Virus
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(string name, string type, int age, double weight)
        {
            Name = name;
            Type = type;
            Age = age;
            Weight = weight;
        }

        public void AddChild(Virus child) => Children.Add(child);

        public Virus Clone()
        {
            var clone = new Virus(Name, Type, Age, Weight);
            foreach (var child in Children)
                clone.AddChild(child.Clone());
            return clone;
        }

        public void ShowInfo(string indent = "")
        {
            Console.WriteLine($"{indent}Вірус: {Name}, Вид: {Type}, Вік: {Age} днів, Вага: {Weight} мкг");
            foreach (var child in Children)
                child.ShowInfo(indent + "  ");
        }
    }
}
