﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name) { }

        public override string GetInfo()
        {
            return $"{Name} (Клас: Warrior)";
        }
    }
}
