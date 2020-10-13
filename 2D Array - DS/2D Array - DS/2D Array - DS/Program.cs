using System;

namespace _2D_Array___DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] arr = new int[6][];
            string input = "1 1 1 0 0 0" ;
            input += "0 1 0 0 0 0" ;
            input += "1 1 1 0 0 0";
            input += "0 0 2 4 4 0" ;
            input += "0 0 0 2 0 0";
            input += "0 0 1 2 4 0";

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(input.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);
        }
        static int hourglassSum(int[][] arr)
        {

            int sum = -1000;
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {

                    int top = arr[i][x] + arr[i][x + 1] + arr[i][x + 2];
                    int middle = arr[i + 1][x + 1];
                    int bottom = arr[i + 2][x] + arr[i + 2][x + 1] + arr[i + 2][x + 2];
                    if (top + middle + bottom > sum) { sum = top + middle + bottom; }
                }
            }
            return sum;
        }
    }
}
