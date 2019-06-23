using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static int[] gradingStudents(int[] grades)
        {
            /*
             * Write your code here.
             */
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Length; i++)
            {
                
                if (grades[i] >= 38)
                {
                    int reminder = grades[i] % 5;

                    if (reminder > 2)
                        grades[i] += (5 - reminder);
                }
                result.Add(grades[i]);
                Console.WriteLine(grades[i]);
            }
            return result.ToArray();

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);
        }
    }
}
