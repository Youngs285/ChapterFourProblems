using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_EnsureValidPayRateLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            while (true)
            {
                string Input;
                Input = Console.ReadLine();
                n = Convert.ToDouble(Input);
                Console.WriteLine("Enter an Hourly Pay Rate:");
                if (n < 5.65 || n > 49.99)
                {


                }
                else
                {
                    break;
                }

                
            }
        }
    }
}
