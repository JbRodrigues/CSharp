// See https://aka.ms/new-console-template for more information
// about the console template and the set of environment variables available.

using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //5,3,6,2,10
            Console.WriteLine(findLower());
        }

        static int findLower()
        {
            int[] lowerArr = { 5, 3, 6, 2, 10 };
            int lower = lowerArr[0];
            int lowerIndex = 0;
            for (int i = 0; i < lowerArr.Length; i++)
            {
                if (lowerArr[i] < lower)
                {
                    lower = lowerArr[i];
                    lowerIndex = i;
                }
            }

            return lower;
        }
    }
}
