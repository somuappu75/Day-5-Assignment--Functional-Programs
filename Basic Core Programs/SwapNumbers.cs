using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public   class SwapNumbers
    { 
        public void Swap()
        {
            int number1, number2, temp;
            Console.Write("\nEnter the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();

        }

    }
}
