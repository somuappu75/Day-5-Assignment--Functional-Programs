using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
   public class LargestNumberOf3
    {
        public void CheckLagestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter The First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            num2 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("The First Nuumber Is Greatest among Three\n");
                }
            }
            if(num2>num3)
            {
                Console.WriteLine("The Second NUmber IS Greatest Among Three\n");
            }
            else
            {
                Console.WriteLine("Third NUmber Is Greatest Among Three\n");
            }
        }
    }
}
