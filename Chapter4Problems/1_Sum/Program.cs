using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0, n;
            while (true)
            {
                Console.Write("Enter a number:");
                string Input = Console.ReadLine();
                

                n = Convert.ToInt32(Input);

                

                if (n > 999)
                {
                    break;
                }
                else
                {
                    result = result + n; 
                }
                System.Console.WriteLine(result);
            }    
        }
    }
}
