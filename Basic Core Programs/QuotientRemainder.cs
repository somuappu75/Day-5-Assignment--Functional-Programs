using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
   public class QuotientRemainder
    { 


        public void ComputeQuotientRemainder()
    {
        int dividend, divisor;
            Console.WriteLine("Enter The dividend");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The dividend");
            divisor= Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
           
        }

    }
}
