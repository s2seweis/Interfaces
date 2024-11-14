using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.SetterDependencyExample
{
    public class Builder
    {
        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        // Comment out for Setter Dependency Injection
        //private Hammer _hammer;
        //private Saw _saw;

        //public Builder()
        //{
        //    _hammer = new Hammer(); // Builder is responsible for creating its dependencies
        //    _saw = new Saw(); // Builder is responsible for creating its dependencies
        //}


        // Constructor Dependency Injection (DI)
        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer;
        //    _saw = saw;
        //}

        // Setter Dependency Injection (DI)
        // no need to call the constructor

        public void BuildHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

/*
 Builder depends on the hammer and the saw
 Saw and hammer are dependencies of the builder
*/
