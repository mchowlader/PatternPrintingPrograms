using System;

namespace HollowInvertedHalfPyramid
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
                    if (i == height)
                    { 
                        Console.Write("* ");
                    }

                    else if(j == 0 || j == i-1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
