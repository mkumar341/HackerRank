using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulTriplets
{
    class Program
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            var count = 0;
            var set = new HashSet<int>(arr);

            foreach (var item in set)
                if (set.Contains(item + d) && set.Contains(item + 2 * d))
                    count++;
            
            return count;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int result = beautifulTriplets(d, arr);
        }
    }
}
