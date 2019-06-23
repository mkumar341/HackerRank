using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeCounter
{
    class Program
    {
        static long strangeCounter(long t)
        {

            int column = (int)(Math.Log((t + 2) / 3) / Math.Log(2));
            long timePower = ((3 * (long)Math.Pow(2, column)) - 2);
            long valuePower = (3 * (long)Math.Pow(2, column));
            long mean = t - timePower;
            long time = valuePower - mean;

            Console.WriteLine(time);
            return time;
        }

        static void Main(string[] args)
        {

            long t = Convert.ToInt64(Console.ReadLine());

            long result = strangeCounter(t);
        }
    }
}
