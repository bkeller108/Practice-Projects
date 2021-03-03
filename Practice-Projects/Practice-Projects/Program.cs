using System;

namespace Practice_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a number between 1 and 10.");

            string input = Console.ReadLine();

            bool isValid = ValidateInput(input);
            string displayText = "InValid";

            if (isValid)
            {
                displayText = "Valid";
            }

            Console.WriteLine(displayText);
            


        }

        private static bool ValidateInput(string input)
        {
            int number;
            if (Int32.TryParse(input, out number))
            {
                if (number >=1 && number <= 10)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
