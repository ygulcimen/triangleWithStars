using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Üçgen
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();


            }
            for (int k = 0; k < 4; k++)
            {
                for (int j = 3; j>=k; j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            //Baklava Dilimi :)
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 2; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z <= y; z++)
                {
                    Console.Write(" ");

                }
                for (int t = 2; t >= y; t--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
