using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "a";
            long n = 1000000000000;
            long result = repeatedString(s, n);

        }
        static long repeatedString(string s, long n)
        {
            var count = 0L;
            foreach (var letter in s)
            {
                if (letter == 'a')
                    count++;
            }

            var possibleCountr = n / s.Length;
            count *= possibleCountr;
            var remainCount = n % s.Length;

            for (int i = 0; i < remainCount; i++)
            {
                if (s[i] == 'a')
                    count++;
            }
            return count;


        }
    }
}
