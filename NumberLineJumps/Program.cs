using System;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(0, 2 ,5 ,3));
        }
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var sameLocationPossible = "";
            if (x1 < x2 && v1 < v2)
                sameLocationPossible = "NO";

            else if (x2 < x1 && v2 < v1)
                sameLocationPossible = "NO";

            else if (x2 < x1)
            {
                //v2 > v1
                var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            else
            {
                //v1 > v2
                var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
                //check whether number of jumps is a whole number  i.e no fractional part.
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            return sameLocationPossible;
        }
    }
}
