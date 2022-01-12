using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
     public class VowelOrConsonant
    {
        public void Vowel()
        {
            char ch;
            Console.WriteLine("Enter a Alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.\n");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.\n");
            }

            else
            {
                Console.WriteLine("IS a Special Character Or Number\n");
                            }

        }
            
        }

    }


