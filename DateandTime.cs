using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Time
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("The current Date and Time is : ");
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
                Console.ReadLine();
            }
        }
    }
