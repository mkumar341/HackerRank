using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumbers
{
    class Program
    {
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            List<int> missing = arr.ToList();

            List<int> original = brr.ToList();
            missing.Sort();
            original.Sort();

            int idxMissing = 0;
            int idxOriginal = 0;

            List<int> result = new List<int>();

            while (idxOriginal < original.Count)
            {
                if ((idxMissing == missing.Count) || (missing[idxMissing] != original[idxOriginal]))
                {
                    result.Add(original[idxOriginal]);
                    idxMissing--;
                }

                idxMissing++;
                idxOriginal++;
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int m = Convert.ToInt32(Console.ReadLine());

            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));
            int[] result = missingNumbers(arr, brr);
        }
    }
}
