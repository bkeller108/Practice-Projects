using System;

namespace LandscapePotraitImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide the Width of image");
            string width = Console.ReadLine();

            Console.WriteLine("Provide the Length of Image");
            string length = Console.ReadLine();

            string mode = DetermineImageMode(width, length);

            Console.WriteLine("Image is {0}", mode);

        }

        private static string DetermineImageMode(string width, string length)
        {
            if (float.TryParse(width, out float w) && float.TryParse(length, out float l))
            {
                if (w > l)
                {
                    return "Landscape";
                }
                else
                {
                    return "Potrait";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
