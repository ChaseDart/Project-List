using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static private List<int> PrimeFactors (int num)
        {
            List<int> factors = new List<int>();

            while (num % 2 == 0)
            {
                factors.Add(2);
                num = num / 2;
            }

            int factor = 3;

            while(factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    factors.Add(factor);
                    num = num / factor;
                }
                else
                {
                    factor = factor + 2;
                }
            }

            if (num > 1) factors.Add(num);

            return factors;
        }

        static void Main(string[] args)
        {
            int num;

            Console.Write("Write a Number and find its Prime Factors: ");
            num = Convert.ToInt32(Console.ReadLine());

            List<int> factors = PrimeFactors(num);

            for(int i = 0; i < factors.Count; i++)
            {
                Console.Write(factors[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
