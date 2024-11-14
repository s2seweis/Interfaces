using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SetterDependencyExample
{
    internal class IndexSetterDependencyExample
    {
        public IndexSetterDependencyExample()
        {
            IndexSetterInjectionExampleMethod();
        }

        private void IndexSetterInjectionExampleMethod()
        {
            Hammer hammer = new Hammer(); // Create the dependencis outside
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.Hammer = hammer; // Inject the dependencies via Setters
            builder.Saw = saw; // Inject dependencies via Setter

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

Setter Injection:
Dependencies are assigned to public setter methods, allowing for the injection of dependencies after the object is created.

 */
