using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class TimeConversion
    {
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            DateTime timeHH = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            return timeHH.ToString("HH:mm:ss");

        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

        }
    }
}
