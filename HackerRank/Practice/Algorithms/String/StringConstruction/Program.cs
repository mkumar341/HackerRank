using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstruction
{
    class Program
    {
        static int stringConstruction(string s)
        {
            int cost = 0;
            StringBuilder deposit = new StringBuilder();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (!deposit.ToString().Contains(s[i]))
                {
                    deposit.Append(s[i]);
                    cost += 1;
                }

            }
            return cost;
        }
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = stringConstruction(s);

            }
        }
    }
}
