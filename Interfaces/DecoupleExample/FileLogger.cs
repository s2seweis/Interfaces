using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DecoupleExample
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string directoryPath = @"C:\Users\SWE\source\repos\Interfaces\Interfaces\DecoupleExample\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, message + "\n");
        }
    }
}
