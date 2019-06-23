using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonelyInteger
{
    class Program
    {
        static int lonelyinteger(int[] a)
        {
            List<int> arrList = a.ToList();
            SortedSet<int> sorted = new SortedSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!sorted.Add(a[i]))
                    arrList.RemoveAll(x => (x == a[i]));
            }

            Console.WriteLine(arrList);
            return arrList[0];
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int result = lonelyinteger(a);

        }
    }
}
