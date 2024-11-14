using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ConstructorInjectionExample
{
    internal class IndexConstructorDependencyExample
    {
        public IndexConstructorDependencyExample()
        {
            IndexConstructorDependencyExampleMethod();
        }

        private void IndexConstructorDependencyExampleMethod()
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();

            // Adjustments for Setter Dependency Injection
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();

            Console.WriteLine("Hello World");
        }
    }
}

/*
Dependency Injection
Dependency injection is programming technique that makes a class independent of its dependencies.
this helps you to follow SOLID's dependency inversion and single responsibility principles

Differnt types of injections

Constructor Injection:
Dependencies are provided through a class constructor, 
ensuring that the class receives all its dependencies at the time of instantiation.
 
 */
