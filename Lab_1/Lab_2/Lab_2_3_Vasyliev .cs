using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Lab_2_3_Vasyliev
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array_1 = new int[5, 5];
            int[,] array_2 = new int[5, 5];
            int[,] array_3 = new int[5, 5];
            int n = 5;

            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    array_1[i, j] = random.Next(10);
                    array_2[i, j] = random.Next(10);
                }
            }

            for (int i = 0; i < array_1.GetLength(0); i++)
            {

                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    Console.Write(array_1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array_2.GetLength(0); i++)
            {
                for (int j = 0; j < array_2.GetLength(1); j++)
                {
                    Console.Write(array_2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nMultiply first array to number {n}");
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    Console.Write(array_1[i, j] * n + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Array sum");
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    Console.Write((array_1[i, j] + array_2[i, j]) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Array Product");
            for (int i = 0; i < array_1.GetLength(0); i++)
            {
                for (int j = 0; j < array_1.GetLength(1); j++)
                {
                    Console.Write((array_1[i, j] * array_2[i, j]) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
