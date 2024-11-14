using Interfaces.ConstructorInjectionExample;
using Interfaces.DecoupleExample;
using Interfaces.DependencyInjectionApp;
using Interfaces.DependencyInjectionExample;
using Interfaces.InterfaceDependencyExample;
using Interfaces.InterfaceExamples;
using Interfaces.LogExample;
using Interfaces.ReusabilityExample;
using Interfaces.SetterDependencyExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndexInterfaceExamples indexInterfaceExamples = new IndexInterfaceExamples();

            //IndexReusabilityExample indexReusabilityExample = new IndexReusabilityExample();

            //IndexLogExample indexLogExample = new IndexLogExample();

            //IndexDecoupleExample indexDecoupleExample = new IndexDecoupleExample();

            //IndexDependencyInjectionExample indexDependencyInjectionExample = new IndexDependencyInjectionExample();

            //IndexConstructorDependencyExample indexConstructorDependencyExample = new IndexConstructorDependencyExample();

            //IndexSetterDependencyExample indexSetterDependencyExample = new IndexSetterDependencyExample();

            //IndexInterfaceDependencyExample indexInterfaceDependencyExample = new IndexInterfaceDependencyExample();

            IndexDependencyInjectionApp app = new IndexDependencyInjectionApp();    

            Console.ReadKey();
        }
    }
}
