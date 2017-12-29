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
            } else if (input == "-ver")
            {
                output = "Console Ver 1.0.0";
            } else if (input.StartsWith("-echo"))
            {
                output = input.Substring(6);
            } else if (input.StartsWith("-count"))
            {
                int max = Convert.ToInt32(input.Substring(7));
                for (int x = 1; x < max +1; x++)
                {
                    output = output + x.ToString() + " ";
                }
            } else if (input.StartsWith("-box"))
            {
                try
                {
                    List<string> listStrLineElements = input.Split(' ').ToList();
                    for (int boxCoordinates = 1; boxCoordinates < Convert.ToInt32(listStrLineElements[2]) + 1; boxCoordinates++)
                    {
                        output = output + "|";
                        for (int boxCoordinates2 = 0; boxCoordinates2 < Convert.ToInt32(listStrLineElements[1]); boxCoordinates2++)
                        {
                            output = output + "- ";
                        }
                        if(boxCoordinates == Convert.ToInt32(listStrLineElements[2])) {
                            output = output + "| ";
                        } else
                        {
                            output = output + "| /n";
                        }
                    }
                } catch
                {
                    output = "Please enter valid x y coordinates e.g. : '-box 5 8'";
                }
            }
            else
            {
                output = "The following string isn't valid. Type -help for a list of valid commands.";
            }

            return output;
        }
    }
}
