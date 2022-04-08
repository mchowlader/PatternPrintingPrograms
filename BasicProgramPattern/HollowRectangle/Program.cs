using System;

namespace HollowRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Hollow Rectancle Height: ");
            var height = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Hollow Rectancle Width: ");
            var width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write("* ");
                    }

                    else if (j == 0 || j == width - 1)
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
