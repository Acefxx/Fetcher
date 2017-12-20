using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fetcher
{
    class StringHelper
    {
        public static string GetDatNow()
        {
            /* Return current date time */
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString() + ": ";
        }
    }
}
