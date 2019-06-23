using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static long repeatedString(string s, long n)
        {
           
            int lenOfAInput = s.Count(x => x == 'a');
            long calc = 0 ;
            calc = (n/ s.Length) * lenOfAInput;
            var offset = n % s.Length;
            for (int i = 0; i < offset; i++)
            {
                if (s[i] == 'a')
                    calc++;
            }
            return calc;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);
        }
    }
}
