using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DecoupleExample
{
    public class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work started");
            // DO ALL THE WORK!
            _logger.Log("Work done!");
        }

    }
}

/*
 Decoupling: The Application class depends on the 
ILogger interface rather than specific implementations 
like FileLogger or Databaselogger.
This mens you can easily switch the logging mechanism without changing the application class. 
 */