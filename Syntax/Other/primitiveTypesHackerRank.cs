using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int a;
        double b;
        string c;

        a = Int32.Parse(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Console.ReadLine();
        Console.WriteLine(a + i);
        Console.WriteLine(string.Format("{0:0.0}", d + b));
        Console.WriteLine(s + c);
        
    }
}