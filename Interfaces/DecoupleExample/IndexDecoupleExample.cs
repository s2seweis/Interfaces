using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DecoupleExample
{

    public interface ILogger
    {
        void Log(string message);
    }

    internal class IndexDecoupleExample
    {
        public IndexDecoupleExample()
        {
            IndexDecoupleExampleMethod();
        }

        private void IndexDecoupleExampleMethod()
        {
        ILogger fileLogger = new FileLogger();
        Application app = new Application(fileLogger);
        app.DoWork();

        ILogger dbLogger = new DatabaseLogger();
        app= new Application(dbLogger);
        app.DoWork();
        }

    }
}

/*
 Interfaces: Decoupling and testability are useful?
Where is it useful?
In large application where components need to interact with each other in a loosely coupled manner.

When is it useful?
Use interfaces when you want to decouple the implementation details from the interface contract, 
especially useful in large and complex systems.
 */

