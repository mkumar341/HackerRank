using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static string superReducedString(string s)
        {
          
            StringBuilder reduced = new StringBuilder();
            reduced.Append(s[0]); // first char
            for (int i = 1; i <  s.Length; i++)
            {
                if (reduced.Length > 0 && s[i] == reduced[reduced.Length - 1])
                {
                    reduced = reduced.Remove(reduced.Length - 1, 1);
                }
                else
                {
                    reduced.Append(s[i]);
                }
               
            }
            return String.IsNullOrEmpty(reduced.ToString()) ? "Empty String" : reduced.ToString();


        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = superReducedString(s);

        }
    }
}
