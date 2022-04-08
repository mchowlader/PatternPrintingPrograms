using System;

namespace SolidRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your rectangle size: ");
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
