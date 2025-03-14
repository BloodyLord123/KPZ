using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Factories;
using task2.Interfaces;

namespace task2.Devices
{
    public class EBook : IDevice
    {
        private string brand;
        public EBook(string brand) => this.brand = brand;
        public void ShowInfo() => Console.WriteLine($"EBook від {brand}");
    }
}
