using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarryArray
{
    class Program
    {
        static string larrysArray(int[] A)
        {
            int cnt = 0;

            for (int i = 0; i < (A.Length - 1); i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                        cnt++;
                }
            }

            bool sorted = (cnt % 2) == 0;
            return sorted == true ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
                string result = larrysArray(A);

            }

        }
    }
}
