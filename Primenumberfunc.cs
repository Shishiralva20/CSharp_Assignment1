using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swapwithfunction
    {
        public static void numSwap(ref int dig1, ref int dig2)
        {
            int temp = 0;
            temp = dig1;
            dig1 = dig2;
            dig2 = temp;

        }
        public static void Main()
        {
            int dig1 = 12;
            int dig2 = 78;
            Console.WriteLine($"Values before swap are {dig1},{dig2}");
            numSwap(ref dig1, ref dig2);
            Console.WriteLine($"Values after swap are {dig1},{dig2}");
        }
    }
}