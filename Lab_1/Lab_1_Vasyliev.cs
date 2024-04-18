//Васильєв Іван Лабораторна 1 варіант 2
using System;
using System.Text;
using static System.Console;


namespace Lab_1_Vasyliev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Обчислення площи трикутника за троьома сторонами");
            Console.Write("Введіть довжину першої сторони: ");
            string numberString = Console.ReadLine();
            float first_side = Convert.ToSingle(numberString);

            Console.Write("Введіть довжину другої сторони: ");
            numberString = Console.ReadLine();
            float second_side = Convert.ToSingle(numberString);

            Console.Write("Введіть довжину третьої сторони: ");
            numberString = Console.ReadLine();
            float third_side = Convert.ToSingle(numberString);



            if (first_side <= 0 || second_side <= 0 || third_side <= 0)
            {
                Console.WriteLine("Довжина сторони трикутника не може бути меншою або дорівнювати 0");
                Console.ReadKey();
            }

            double p = (first_side + second_side + third_side) / 2;
            double area = Math.Sqrt(p * (p - first_side) * (p - second_side) * (p - third_side));
            Console.WriteLine($"Площа заданого вами трикутника дорівнює {area}");
            Console.ReadKey();
        }
    }
}
