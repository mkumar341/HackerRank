using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            double jumps;
            if (x1 > x2 && v1 > v2)
            {
                return "NO";
            }
            else if (x2 > x1 && v2 > v1)
            {
                return "NO";
            }
            else if (x1 > x2)
            {
                jumps = ((double)(x1 - x2) / (v2 - v1));
            }
            else  
            {
                jumps = ((double)(x2 - x1) / (v1 - v2));
            }
           
            if (jumps % 1 == 0)
                return "YES";
            else
                return "NO";


        }
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);
        }
    }
}
