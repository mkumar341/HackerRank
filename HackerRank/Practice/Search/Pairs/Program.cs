using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Program
    {
        static int pairs(int k, int[] arr)
        {
            Array.Sort(arr);

            int count = 0;

            for (int i = 0; i < (arr.Length - 1); i++)
            {
                if (Array.BinarySearch(arr, (i + 1), arr.Length - (i + 1), arr[i] + k) >= 0)
                    count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = pairs(k, arr);

        }
    }
}
