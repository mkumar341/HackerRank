using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class AppleOrange
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleSam = 0;
            int orangeSam = 0;
            for (int i = 0; i <= apples.Length - 1; i++)
            {
                int appleX = a + apples[i];
                if ( appleX >= s && appleX <= t)
                    appleSam++;
            }
            for (int i = 0; i <= oranges.Length - 1; i++)
            {
                int orangeX = b + oranges[i];
                if (orangeX >= s && orangeX <= t)
                    orangeSam++;
            }
            Console.WriteLine(appleSam);
            Console.WriteLine(orangeSam);
        }

        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
