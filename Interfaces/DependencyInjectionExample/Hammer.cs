﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DependencyInjectionExample
{
    public class Hammer
    {
        public Hammer()
        {

        }

        public void Use()
        {
            Console.WriteLine("Hammering nails!");
        }
    }
}
