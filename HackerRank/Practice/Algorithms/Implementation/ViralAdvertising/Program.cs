using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            var totalLikes = 0D;
            var AdShareCount = 5.0;
            for (int i = 0; i < n; i++)
            {
                totalLikes += Math.Floor(AdShareCount / 2);
                AdShareCount = Math.Floor(AdShareCount / 2) * 3;
            }
            Console.WriteLine(totalLikes);
            return Convert.ToInt32(totalLikes);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);
        }
    }
}
