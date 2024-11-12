using Interfaces.InterfaceExamples;
using Interfaces.ReusabilityExample;
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

            IndexReusabilityExample indexReusabilityExample = new IndexReusabilityExample();

            Console.ReadKey();
        }
    }
}
