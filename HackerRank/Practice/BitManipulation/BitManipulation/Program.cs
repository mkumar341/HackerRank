using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    class Program
    {
        static long flippingBits(long n)
        {
            string binNum = Convert.ToString(n, 2).PadLeft(32, '0');
           
            string flipped = String.Concat(binNum.Select(b => b == '0' ? '1' : '0'));
            
            long longNum = Convert.ToInt64(flipped, 2);
            return longNum;

        }
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                long result = flippingBits(n);

            }

        }
    }
}
