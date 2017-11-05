using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Validator
    {

        public static bool ValidatePurchase(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                Console.WriteLine("\nExcellent! Our finance department will be with you shortly. \n");
                
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid input. ");
                return ValidatePurchase(prompt);
            }
        }
    }
}
