using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static int camelcase(string s)
        {
            int count = 0;

            for (int i = 0; i <= s.Length -1; i++)
            {
                int ascii = (int)s[i];
                if (i == 0 && !(ascii >= 65 && ascii <= 90))
                {
                    count += 1;
                }
                else if (ascii >= 65 && ascii <= 90)
                {
                    count += 1;
                }
            }
            return count;
        }


        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);
        }
    }
}
