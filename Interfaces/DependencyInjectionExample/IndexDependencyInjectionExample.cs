using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DependencyInjectionExample
{
    internal class IndexDependencyInjectionExample
    {
        public IndexDependencyInjectionExample()
        {
            IndexDependencyInjectionExampleMethod();
        }

        private void IndexDependencyInjectionExampleMethod()
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

Differnt types of injections overview:

Constructor Injection:
Dependencies are provided through a class constructor, 
ensuring that the class receives all its dependencies at the time of instantiation.

Setter Injection:
Dependencies are assigned to public setter methods, allowing for the injection of dependencies after the object is created.

Interface Injection:
Dependencies are provided through an interface that exposes a method for injecting the dependency. 

 */
