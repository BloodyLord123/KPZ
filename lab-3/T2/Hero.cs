using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public abstract class Hero
    {
        public string Name { get; set; }

        public Hero(string name)
        {
            Name = name;
        }

        public abstract string GetInfo();
    }
}
