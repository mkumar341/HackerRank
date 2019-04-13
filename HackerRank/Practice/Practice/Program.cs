using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the staircase function below.
    static void staircase(int n)
    {
        
        for (int x=0;x<n;x++)
        {
            String stair = new String('#',x + 1);
            Console.WriteLine(stair.PadLeft(n,' '));

        }


        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
