using System;

namespace HollowHalfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Pyramid Height: ");
            var heigt = int.Parse(Console.ReadLine());

            for (int i = 0; i < heigt; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == 0 || i == heigt-1)
                    {
                        Console.Write("* ");
                    }

                    else if(j == 0 || j == i)
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
