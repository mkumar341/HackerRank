using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairRations
{
    class Program
    {
        static string fairRations(int[] B)
        {
            int total = 0;
            int count = 0;
            
            bool stock = false;

            for (int i = 0; i < B.Length; i++)
            {
                if (stock && (B[i] % 2 != 0))
                {
                    count++;
                    total += (2 * count);
                    stock = false;
                    count = 0;
                }
                else if (stock)
                    count++;
                else if (B[i] % 2 != 0)
                    stock = true;
            }

            if (stock)
                Console.WriteLine("NO");
            else
                Console.WriteLine(total);

            return total == 0 ? "NO" : total.ToString();
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));
            string result = fairRations(B);

        }
    }
}
