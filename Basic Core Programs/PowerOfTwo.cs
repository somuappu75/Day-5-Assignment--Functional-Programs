using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    public class PowerOfTwo
    {

        public PowerOfTwo(string argument)
        {
            Console.WriteLine("Take command-line argument");
            double number = Convert.ToInt32(argument);          // converting string value to int
            Inherit utility = new Inherit();
            Console.Write("[ ");

            for (int i = 0; i <= number; i++)
            {
                double result = utility.PowerOfTwo(i);
                Console.Write(result + " ");
            }

            Console.WriteLine("]");
        }
    }
    }

