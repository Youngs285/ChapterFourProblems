using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Type a Vowel:");
                string Input = Console.ReadLine();

                if (Input[0] == 'a' || Input[0] == 'A' || Input[0] == 'e' || Input[0] == 'E' || Input[0] == 'I' || Input[0] == 'i' || Input[0] == 'o' || Input[0] == 'O' || Input[0] == 'u' || Input[0] == 'U')
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("That is not a Vowel try again");
                }
            }

        }
    }
}
