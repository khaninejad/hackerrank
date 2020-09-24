using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SalesbyMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] ar= { 10 ,20 ,20, 10 ,10, 30 ,50, 10 ,20,50 } ;


            Console.Write(sockMerchant(n, ar));

        }
        static int sockMerchant(int n, int[] ar)
        {
            return ar.GroupBy(a => a).Sum(a => a.Count() / 2);

        }
    }
}
