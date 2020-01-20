using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 - 15 to find PI to the Nth Digit:");
            string nth = Console.ReadLine();

            Console.WriteLine("\n" + Math.Round(Math.PI, Convert.ToInt32(nth)));

            Console.ReadLine();
        }
    }
}
