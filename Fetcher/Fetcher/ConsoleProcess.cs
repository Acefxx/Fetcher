using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fetcher
{
    class ConsoleProcess
    {
        public static string checkCommand(string input)
        {
            string output = string.Empty;

            if (input == "-help")
            {
                output = "Welcome to Fetcher, command processor.";
            }

            return output;
        }
    }
}
