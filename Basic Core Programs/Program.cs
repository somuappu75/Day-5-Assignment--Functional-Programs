using bridgepro1;
using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("-------------Basic Functional Programs--------------");
                    
                    Console.WriteLine("1.Flip Coin \n2.Leap Year \n3.Harmonic Series" +
                    "\n4.Power Of 2\n5.Prime Factors \n6.Quotient And Remainder " +
                    "\n7.Swapping Numbers \n8.Check Even Or Odd  \n9.Vowel Or Consonant \n10.Largest Number Of 3 \n11.Exit ");
                    Console.WriteLine("\nEnter Your Option:");
                    int option = Convert.ToInt32(Console.ReadLine());       // converting string value to int
                    //// switch case for accessing block of program in given cases. 
                    switch (option)
                    {
                        
                            

                        case 1:
                            //// create FlipCoin class object to accessing FlipCoin class. 
                            FlipCoin flip = new FlipCoin();
                            flip.FlipTheCoin();
                            break;

                        case 2:
                            //// create LeapYear class object to accessing LeapYear class. 
                            LeapYear year = new LeapYear();
                            year.Leap();
                            break;
                        case 3:
                            //// create Harmonic class object to accessing Harmonic class. 
                            Harmonic harmonic = new Harmonic();
                            harmonic.HarmonicNumber();
                            break;
                        case 4:
                            //// create PoweofTwo class object to accessing PowerofTwo class.  
                            PowerOfTwo power = new PowerOfTwo(args[0]);
                            break;
                        case 5:
                            //// create Factors class object to accessing Factors class. 
                            Factors prime = new Factors();
                            prime.PrimeFactors();
                            break;

                        case 6:
                            //// create QuotientRemainder class object to accessing Qrcompute class. 
                            QuotientRemainder quotient = new QuotientRemainder();
                            quotient.ComputeQuotientRemainder();
                            break;
                        case 7:
                            ////Swapnumber Class object to accessing swap method.
                            SwapNumbers swap = new SwapNumbers();
                            swap.Swap();
                            break;
                        case 8:
                            ////EveorOdd class object to Accessing Compute method.
                            EvenOrOdd even = new EvenOrOdd();
                            even.ComputeEvenOrodd();
                            break;
                        case 9:
                            // vowel method from vowelorConsonant Class
                            VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                            vowelOrConsonant.Vowel();
                            break;
                        case 10:
                            // Checklargest method from lagestnumberof3 Class
                            LargestNumberOf3 largestNumberOf3 = new LargestNumberOf3();
                            largestNumberOf3.CheckLagestNumber();
                            break;
                            

                        case 11:
                            //// flag tends to false for breaking while loop.
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Wrong option! please enter option again.");
                            break;
                    }
                }
            }
            catch (Exception)
            {                                                     //// check for excepton and give the message to console
                Console.WriteLine("Please Enter valid Input");
                //// by using goto the excusion starts from validation1 label.
                
            }
            //// holds the console.
            Console.ReadKey();
        }
    }
}
