using System;
using System.Collections.Generic;
using System.Text;

namespace bridgepro1
{
     public class FlipCoin
    {
        public  void FlipTheCoin()
        {
            Console.WriteLine("Please Enter the value for flips");

            int Head = 0;
            int Tail = 0;
            int Headcount = 0;
            int Tailcount = 0;
            double headpercentage;
            double tailpercentage;

            int flipcoin = Convert.ToInt32(Console.ReadLine());
            if (flipcoin >= 0)
            {
                for (int i = 1; i <= flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 1)
                    {
                        Head = 1;
                        Headcount += Head;
                    }
                    else if (number == 0)
                    {
                        Tail = 1;
                        Tailcount += Tail;
                    }
                    Console.WriteLine(number);
                }
                Console.WriteLine("-------");
                headpercentage = (Headcount * 100) / flipcoin;
                tailpercentage = (Tailcount * 100) / flipcoin;
                Console.WriteLine("Headpercentage :" + headpercentage);
                Console.WriteLine("Tailpercentage:" + tailpercentage);

            }
            else
            {
                Console.WriteLine("Please enter positive enter");
            }

        }

    }

}

