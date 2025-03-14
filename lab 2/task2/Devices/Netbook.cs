using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Factories;
using task2.Interfaces;

namespace task2.Devices
{
    public class Netbook : IDevice
    {
        private string brand;
        public Netbook(string brand) => this.brand = brand;
        public void ShowInfo() => Console.WriteLine($"Netbook від {brand}");
    }
}
