using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = Array.ConvertAll("0 0 0 1 0 0".Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c);
        }

        static int jumpingOnClouds(int[] c)
        {
            int jumpCount = 0;
            int position = 0;
            for (int i = position; i < c.Length; i++)
            {
                if (position >= c.Length - 1)
                    break;
                if (position + 2 <= c.Length - 1 && c[position + 2] == 0)
                {
                    position += 2;
                }
                else
                {
                    position++;
                }

                jumpCount++;

            }

            return jumpCount;
        }
    }
}
