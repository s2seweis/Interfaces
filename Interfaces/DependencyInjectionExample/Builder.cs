using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DependencyInjectionExample
{
    public class Builder
    {

        private Hammer _hammer;
        private Saw _saw;

        //public Builder()
        //{
        //    _hammer = new Hammer(); // Builder is responsible for creating its dependencies
        //    _saw = new Saw(); // Builder is responsible for creating its dependencies
        //}

        // Constructor Dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer;
            _saw = saw;
        }


        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }
    }
}

/*
 Builder depends on the hammer and the saw
 Saw and hammer are dependencies of the builder
*/
