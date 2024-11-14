using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DependencyInjectionApp
{
    // Both of these interfaces have a simple method, but it could have a bunch of properties as well as many methods
    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }
    internal class IndexDependencyInjectionApp
    {
        public IndexDependencyInjectionApp()
        {
            IndexDependencyInjectionAppMethod();
        }

        private void IndexDependencyInjectionAppMethod()
        {
            MultiFunctionPrinter printer = new MultiFunctionPrinter();
            printer.Print();
            printer.Scan();
            //Console.WriteLine("Hello World!");
        }
    }
}

/*
 Simple example of how multiple inheritance can be achivied
 */
