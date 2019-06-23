using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizingXOR
{
    class Program
    {
        static int maximizingXor(int l, int r)
        {

            int maxValue = 0;

            for (int i = l; i <= r; i++)
            {
                for (int b = i; b <= r; b++)
                {
                    int xor = (i | b) & (~(i & b));

                    if (xor > maxValue)
                        maxValue = xor;
                }
            }

            Console.WriteLine(maxValue);
            return maxValue;
        }

        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());

            int r = Convert.ToInt32(Console.ReadLine());

            int result = maximizingXor(l, r);

        }
    }
}
