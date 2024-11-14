using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.InterfaceDependencyExample
{
    internal class IndexInterfaceDependencyExample
    {
        public interface IToolUser
        {
            void SetHammer(Hammer hammer);
            void SetSaw(Saw saw);
        }

        public IndexInterfaceDependencyExample()
        {
            IndexInterfaceDependencyMethod();
        }

        private void IndexInterfaceDependencyMethod()
        {
            Hammer hammer = new Hammer(); // Create the dependencis outside
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.SetHammer(hammer);
            builder.SetSaw(saw);

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

Interface Injection:
Dependencies are provided through an interface that exposes a method for injecting the dependency. 

 */

/*
 Important
Why Interface Dependency Injection?
=> Flexibility 

Dependencies are injected through interface methods, 
allowing the class to receive its dependencies from an external source 
 */
