using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
   public class Factors
    {
        public void PrimeFactors()
        {
                
                Console.WriteLine("Enter a value");
            int number = Convert.ToInt32(Console.ReadLine());       // converting string value to int
            Console.Write("Factors=\n");
            for (int i = 2; i * i <= number; i++)
            {                                                         // for loop iterates to the given number
                while (number % i == 0)
                {                                                    // checking for perfect divisible value
                    Console.Write(i + " ");

                    number = number / i;
                }

            }
            if (number > 1)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }
    }
    }

