using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Negativenumbers
    {
        public static void Main()
        {
            int[] arr = { -12, -34, 3, -67, -97, 30 };
            int i, n;
            n = arr.Length;
            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}