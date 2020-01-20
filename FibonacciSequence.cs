using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;
            int n3;

            Console.WriteLine("Enter a Number to generate a Fibbonacci Sequence Length: ");
            string j = Console.ReadLine();

            Console.Write(n1 + " " + n2 + " ");

            for(int i = 0; i < Convert.ToInt32(j) - 2; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
