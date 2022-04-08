using System;

namespace HalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Pyramid Height: ");
            var height = int.Parse(Console.ReadLine());

            for (int i = 0; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
