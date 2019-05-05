using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        // Complete the encryption function below.
        static string encryption(string s)
        {

            int matrixCols = (int)Math.Ceiling(Math.Sqrt(s.Length));
            int matrixRows = (int)Math.Floor(Math.Sqrt(s.Length));
            StringBuilder output = new StringBuilder();

            for (int x = 0; x < matrixCols; x++)
            {
                int charPoint = x;

                for (int i = 0; i <= matrixRows; i++)
                {
                    if (charPoint < s.Length)
                    {
                        output.Append(s[charPoint]);
                    }
                    charPoint += matrixCols;
                }
                output.Append(" ");

            }
            return output.ToString();

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = encryption(s);

            //textWriter.WriteLine(result);
       

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
