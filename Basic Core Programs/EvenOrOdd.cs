using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
   public class EvenOrOdd
    {
        public void ComputeEvenOrodd()
        {
            int num1, rem1;
            Console.WriteLine("Enter The Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even Number.\n", num1);
            else
                Console.WriteLine("{0} is an odd Number.\n", num1);
        }
    }

}
        
        
    

