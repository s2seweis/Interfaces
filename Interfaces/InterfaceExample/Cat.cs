using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.InterfaceExamples
{
    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("The cat is eating her favourite food: " + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("The cat makes meaow");
        }
    }
}
