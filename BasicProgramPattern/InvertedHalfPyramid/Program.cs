using System;

namespace InvertedHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Pyramid Height: ");
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = height; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
