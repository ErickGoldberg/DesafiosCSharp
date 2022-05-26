using System;
namespace DesafiosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t Desafios C#");
            for (int c = 0; c < 6; c++)
            {
                for (int i = 0; i <= c; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int f = 0; f <= 4; f++)
            {
                for (int j = 4; j > f; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}