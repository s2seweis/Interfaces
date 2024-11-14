using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.LogExample
{
    internal class IndexLogExample
    {
        public IndexLogExample()
        {
            IndexLogExampleMethod();
        }

        private void IndexLogExampleMethod()
        {
            // verbatim strig literal
            // The @ sign in C# is used to denote a verbatim string literal

            //string directoryPath = "C:\\Logs"; // or use an @ at the start of the string 
            //string directoryPath = @"C:\Logs";
            string directoryPath = @"C:\Users\SWE\source\repos\Interfaces\Interfaces\LogExample\Logs";
        //C: \Users\SWE\source\repos\Interfaces\Interfaces\LogExample\Logs
            string filePath = Path.Combine(directoryPath, "log.txt");
            string message = "This is a log entry";

            // If the directoryPath does not exists then create an directory
            if(!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, message + "\n");
        }
    }
}
