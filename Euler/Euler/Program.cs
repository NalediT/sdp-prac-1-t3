using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution to Problem 7: The 10001th Prime

            bool Is_Prime(int n)
            {
                int dividers = 0, J = 1;
                while (J <= Math.Sqrt(n))
                {
                    if (n % J == 0)
                        dividers++;
                    J++;
                }
                if (dividers > 1)
                    return false;
                return true;
            }
            int prime_count = 0, k = 2;
            while (prime_count < 10001)
            {
                if (Is_Prime(k))
                    prime_count++;
            }
            k++;
            Console.WriteLine(string.Format("Euler: \t Problem 7\nThe {0}th Prime is {1}\n", prime_count, k - 1));

            //created by ShadowScreamz
            //Prac 1 Task 3 Euler
            //solution to Euler Problem 3: Largest Prime Factor

            long number = 600851475143;
            long largestprimefactor = 0;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)                //number is a prime
                {

                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)             //number is not a prime
                        {
                            break;
                        }
                        else
                        {
                            largestprimefactor = i;
                        }
                        Console.WriteLine($"the largest prime factor for {number} is : {largestprimefactor}");
                        Console.ReadLine();
                    }

                }
            }

        }
    }
}
