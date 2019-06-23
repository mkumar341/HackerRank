using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            //var count = ar.GroupBy(x => x).Where(x => x.Count() > 1 );
            int count= 0;
            var listArray = ar.ToList().Distinct();
            foreach (int item in listArray)
            {
                int temp = ar.Where(x => x.Equals(item)).Count();
                if (temp > 1)
                {
                    count += temp / 2;
                }
            }
       
            return count;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
        }
    }
}
