using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Minmax
    {
        public static void Main()
        {
            int[] arr = { 20, 24, 6, 45, 3, 98 };
            int i, max, min, n;
            n = arr.Length;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum number = {0}\n", max);
            Console.Write("Minimum number = {0}\n", min);
        }
    }
}