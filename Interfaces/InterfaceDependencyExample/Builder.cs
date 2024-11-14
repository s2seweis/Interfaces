using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.InterfaceDependencyExample.IndexInterfaceDependencyExample;

namespace Interfaces.InterfaceDependencyExample
{
    public class Builder: IToolUser 
    {
        private Hammer _hammer;
        private Saw _saw;

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House built!");
        }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
    }
}

/*
 Builder depends on the hammer and the saw
 Saw and hammer are dependencies of the builder
*/
