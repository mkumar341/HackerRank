using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum
{
    class Program
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            var totalSum = 0;
            
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                //total count
                totalSum += arr[i];

            

            }
            Console.WriteLine(string.Format("Min: {0}, Max:{1}", totalSum - arr.Max(), totalSum - arr.Min()));

        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            miniMaxSum(arr);
        }

    }
}
