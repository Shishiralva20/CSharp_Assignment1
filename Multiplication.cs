using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Multiplication
    {
        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int res = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",num1, num2, num3, res);
        }
    }
}