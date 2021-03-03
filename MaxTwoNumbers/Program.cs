using System;

namespace MaxTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number 1" );
            var input1 = Console.ReadLine();

            Console.WriteLine("Input Number 2");
            var input2 = Console.ReadLine();

            int maxNum = GetMaxNumber(input1, input2);

            Console.WriteLine("Maximum Number {0}", maxNum);



        }

        private static int GetMaxNumber(string value1, string value2)
        {
            if(Int32.TryParse(value1, out int number1) && Int32.TryParse(value2, out int number2))
            {
                if (number1 > number2)
                {
                    return number1;
                }
                else
                {
                    return number2;
                }
            }

            return 0;
        }
    }
}
