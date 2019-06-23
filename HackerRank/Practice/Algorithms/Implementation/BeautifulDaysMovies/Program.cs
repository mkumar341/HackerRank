using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysMovies
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {

            int count = 0;

            while (i <= j)
            {
                char[] charArray = i.ToString().ToCharArray();
                Array.Reverse(charArray);               

                if ((Math.Abs(i - Reverse(i)) % k) == 0)
                    count++;

                i++;
            }

            Console.WriteLine(count);
            return count;
        }

        static int Reverse(int number)
        {
            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(new string(charArray));
        }

        static void Main(string[] args)
        {

            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

        }
    }
}
