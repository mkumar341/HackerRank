using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamParlor
{
    class Program
    {
        static int[] icecreamParlor(int m,int n, int[] arr)
        {
            List<int> result = new List<int>();
            for (int j = 0; j < n; j++)
            {
                for (int k = (j + 1); k < n; k++)
                {
                    if (arr[j] + arr[k] == m)
                    {
                        Console.WriteLine((j + 1) + " " + (k + 1));
                        result.Add((j + 1));
                        result.Add((k + 1));

                    }
                }
            }
            return result.ToArray();

        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                int[] result = icecreamParlor(m,n, arr);

            }
        }
    }
}
