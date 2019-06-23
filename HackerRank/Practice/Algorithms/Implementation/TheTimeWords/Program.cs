using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTimeWords
{
    class Program
    {
        static string timeInWords(int h, int m)
        {
            var hourWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" };
            var minuteWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                                    , "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"
                                    , "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight","twenty nine" };


            if (m == 0)
                return $"{hourWords[h - 1]} o' clock";

            if ((m > 0 && m < 15) || (m > 15 && m < 30))
                return $"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}";

            if ((m > 30 && m < 45) || (m > 45 && m < 60))
                return $"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}";

            if (m == 15)
                return $"quarter past {hourWords[h - 1]}";

            if (m == 30)
                return $"half past {hourWords[h - 1]}";

            if (m == 45)
                return $"quarter to {hourWords[h]}";

            return "";
        }

        static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);
        }
    }
}
