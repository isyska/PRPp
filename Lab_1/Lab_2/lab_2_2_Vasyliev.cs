using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class lab_2_2_Vasyliev
    {

        public static void Main(string[] args)
        {

            int[,] array = new int[2, 6];
            Random random = new Random();
            

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(10);
                }
            }

            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < columns; j++)
            {
                int maxValue = array[0, j];
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] >  maxValue
                    {
                        maxValue = array[i, j];
                    }

                }
                Console.WriteLine($"Max value at {j+1} = {maxValue}");
            }

            Console.ReadLine();
        }
    }
}
