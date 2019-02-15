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
            //created by ShadowScreamz
            //Prac 1 Task 3 Euler
            //solution to Euler Problem 3: Largest Prime Factor
            
            long number = 600851475143; 
            long largestprimefactor= 0;

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
