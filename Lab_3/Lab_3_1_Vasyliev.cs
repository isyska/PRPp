using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{


    public class Autobase
    {
        public int number { get; set; }
        public string name { get; set; }
        public int used_fuel { get; set; }
        public int automobiles_count { get; set; }
        public double Average_fuel_consumption()
        {
            return (used_fuel / automobiles_count);
        }
    }

    public class Autobases
    {
        public List<object> listAutobases = new List<object>();
        public void addAutobases(Autobase autobases)
        {
            listAutobases.Add(autobases);
        }
        public void printAutobases()
        {
            foreach (var autobase in listAutobases)
            {
                Autobase a = (Autobase)autobase;
                Console.WriteLine($"Number: {a.number},Name {a.name}, Used fuel: {a.used_fuel}, Automobiles count: {a.automobiles_count}, Average fuel consumption {a.Average_fuel_consumption()}");
            }
        }

        public int sum_used_fuel()
        {
            int sum = 0;
            foreach (var autobase in listAutobases)
            {
                Autobase a = (Autobase)autobase;
                sum += a.used_fuel;

            }
            return sum;
        }

        public int sum_automobiles_count()
        {
            int sum = 0;
            foreach (var autobase in listAutobases)
            {
                Autobase a = (Autobase)autobase;
                sum += a.automobiles_count;

            }
            return sum;
        }

        public double average_used_fuel()
        {
            double sum = 0;
            foreach (var autobase in listAutobases)
            {
                Autobase a = (Autobase)autobase;
                sum += a.Average_fuel_consumption();

            }
            return sum/listAutobases.Count;
        }

    }



    internal class lab_3_1_Vasyliev
    {
        public static void Main(string[] args)
        {
            Autobase autobase1 = new Autobase() { number = 1, name = "MARCETOPT", used_fuel = 14, automobiles_count = 3 };

            Autobase autobase2 = new Autobase() { number = 2, name = "ATB", used_fuel = 2000, automobiles_count = 10 };
            Console.WriteLine($"Average_fuel_consumption {autobase1.Average_fuel_consumption()} KG");


            Autobases autobases = new Autobases();
            autobases.addAutobases(autobase1);
            autobases.addAutobases(autobase2);
            autobases.printAutobases();

            Console.WriteLine($"Sum used fuel {autobases.sum_used_fuel()}");
            Console.WriteLine($"Sum cout cars{autobases.sum_automobiles_count()}");
            Console.WriteLine(autobases.average_used_fuel());    
        }
    }
}