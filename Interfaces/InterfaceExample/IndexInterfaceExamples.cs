using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.InterfaceExamples
{
    public interface IAnimal
    {
        void MakeSound();

        void Eat(string food);
    }
    internal class IndexInterfaceExamples
    {
        public IndexInterfaceExamples()
        {
            IndexInterfaceExamplesMethod();
        }

        private void IndexInterfaceExamplesMethod()
        {
            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Eat("Treat");

            //Cat cat = new Cat();
            //cat.MakeSound();
            //cat.Eat("Fish");

            //Part 2 of Polymorphism
            // Dog inherits from Animal
            // Whenever a class is inherting from another class, we can use it as here
            Animal myHound = new Hound();
            myHound.MakeSound();

            // This way around it does not work
            //Dog myNewHound = new Animal();

        }
    }
}

/*
 What is Polymorphism?
Polymorphisim, derrived from Greek meaning "many shapes", 
refers to the ability in programming where a single interface 
or method can operate in multiple ways based on the object it interacts with. 

One Interface, Many Implementations:
A single function or methodcan handle objects of various types. 
The implementation depends on the specific object being referenced

Flexibility:
Write adabtable and reusable code.
Methods can work with different object types without knowing the specific types in advance.

Code maintenance:
Simplifies maintenance and extension. 
New object types can be added easily if they conform to the expected interface or base class. 

Simpliefies Code:
Enables treating different objects uniformly 
Reduces complexity by handling diverse objects through a common interface 

=> Powerful concept*

 */
