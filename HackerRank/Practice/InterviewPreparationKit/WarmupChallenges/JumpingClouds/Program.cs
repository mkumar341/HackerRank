using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingClouds
{
    class Program
    {
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {

                if (i +2 < c.Length && c[i+ 2] == 0)
                {
                    jumps++;
                    i++;
                }
                else
                {
                    jumps++;
                }
                
                
            }
            return jumps;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);
        }
    }
}
