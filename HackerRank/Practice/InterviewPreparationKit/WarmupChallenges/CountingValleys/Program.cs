using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            int level = 0;
            int valley = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'D')
                {
                    level= level - 1;
                }
                else if (s[i] == 'U')
                {
                    level = level + 1;

                }
                if (level == 0 && s[i] == 'U')
                    valley = valley + 1;
            }
            return valley;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);
        }
    }
}
