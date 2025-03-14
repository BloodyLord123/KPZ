using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Character
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public string HairColor { get; set; }
        public string EyesColor { get; set; }
        public int Weight { get; set; }
        public string Height { get; set; }
        public List<string> Actions { get; set; } = new List<string>();
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Clothing { get; set; } = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Вік: {Years} років");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyesColor}");
            Console.WriteLine($"Вага: {Weight} кг");
            Console.WriteLine($"Зріст: {Height}");
            Console.WriteLine($"Одяг: {string.Join(", ", Clothing)}");
            Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");
            Console.WriteLine($"Вчинки: {string.Join(", ", Actions)}\n");
        }
    }

}
