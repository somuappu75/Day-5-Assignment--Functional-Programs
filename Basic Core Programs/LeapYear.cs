using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
   public class LeapYear
    {
        public void Leap()
        { 

                Console.WriteLine("Enter The Year");
                int year = int.Parse(Console.ReadLine());
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine(" is a Leap Year" + year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap Year.", year);
                    Console.ReadLine();
                }
            }
        }
        }
    

