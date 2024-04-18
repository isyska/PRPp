//Васильєв Іван Лабораторна 1 варіант 2 (Знайти найменший денний виробіток)
using System;
using System.Text;
using static System.Console;


namespace Lab_2_1_Vasyliev
{
    internal class Program
    {
        static void PrintArr<T>(string PassString, T[] arr)
        {
            WriteLine(PassString);
            foreach (var el in arr) { Write(el); Write('\t'); }
            WriteLine();
        }
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Random random = new Random();
            int minProduction = int.MaxValue;

            int[] daily_production = new int[10];
            for (int i = 0; i < daily_production.Length; i++)
            {
                daily_production[i] = random.Next(37);
            }

            

            for (int i = 0; i < daily_production.Length; i++)
            {
                
                if (daily_production[i] < minProduction)
                {
                    minProduction = daily_production[i];
                }
            }
            PrintArr("Виробіток", daily_production);
            Console.WriteLine("Найменший денний виробіток: {0}", minProduction);
            Console.ReadLine();

        }
    }
}
