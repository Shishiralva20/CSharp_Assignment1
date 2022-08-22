using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your age after 10 years:");
            age = age + 10;
            Console.Write("{0} ", age);
        }
    }
}

