using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ExceptionHandling
    {
        public static bool CorrectSel(int sel, int numChoices)
        {
            bool success = false;

            if (sel >= 0 && sel <= numChoices)
            {
                success = true;
            }
            else
            {
                Console.WriteLine($"({sel}) is not a valid option. Option ranges from 0 to " + numChoices);
                Console.WriteLine();
            }

            return success;
        }

        public static int GetCorrectSel(int numChoices)
        {
            int sel;
            bool success = false;

            do
            {
                Console.Write($" Please make a selection (1-({numChoices}), or 0 to exit): ");
                sel = GetInt();

                success = CorrectSel(sel, numChoices);
            }
            while (!success);

            return sel;
        }

        public static int GetInt(String message = null, bool fourDigit = false)
        {
            int number;
            bool success = false;

            do
            {
                if (message != null)
                {
                    Console.Write(message);
                }

                success = Int32.TryParse(Console.ReadLine(), out number);

                if (fourDigit == true)
                {
                    if (!(number >= 1000 && number <= 9999))
                    {
                        success = false;
                        Console.WriteLine("The password must be 4-digit.");
                    }
                    else
                    {
                        success = true;
                    }
                }

                if (success == false)
                {
                    Console.Write("Please enter a number: ");
                }
            }
            while (!success);

            return number;
        }
    }
}
