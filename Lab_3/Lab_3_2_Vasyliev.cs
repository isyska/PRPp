using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class City
    {
        private string _cityName;
        private string _countryName;
        private int _population;
        private int _postalCode;
        private string[] _districts;
        private int _cityCount;
        private int _totalPopulation;

        public City(string cityName, string countryName, int population, int postalCode, string[] districts)
        {
            _cityName = cityName;
            _countryName = countryName;
            _population = population;
            _postalCode = postalCode;
            _districts = districts;

            _cityCount++;
            _totalPopulation += population;
        }

        public string GetCityName()
        {
            return _cityName;
        }
        public void SetCityName(string cityName)
        {
            _cityName = cityName;
        }

        public string GetCountryName()
        {
            return _countryName;
        }
        public void SetCountryName(string countryName)
        {
            _countryName = countryName;
        }

        public int GetPopulation()
        {
            return (int)_population;
        }
        public void SetPopulation(int population)
        {
            _population = population;
        }

        public int GetPostalCode()
        {
            return (int)_postalCode;
        }
        public void SetPostalCode(int postalCode)
        {
            _postalCode = postalCode;
        }

        public string[] GetDistricts()
        {
            return _districts;
        }
        public void SetDistricts(string[] districts)
        {
            _districts = districts;
        }

        public int GetCityCount()
        {
            return _cityCount;
        }
        public int GetTotalPopulation()
        {
            return _totalPopulation;
        }

        public void InputData()
        {
            Console.Write("Введiть назву мiста: ");
            _cityName = Console.ReadLine();

            Console.Write("Введiть назву країни: ");
            _countryName = Console.ReadLine();

            Console.Write("Введiть кiлькiсть жителiв: ");
            _population = int.Parse(Console.ReadLine());

            Console.Write("Введiть поштовий iндекс: ");
            _postalCode = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть районiв: ");
            int districtCount = int.Parse(Console.ReadLine());

            _districts = new string[districtCount];

            for (int i = 0; i < districtCount; i++)
            {
                Console.Write($"Введiть назву району {i + 1}: ");
                _districts[i] = Console.ReadLine();
            }
        }

        public void OutputData()
        {
            Console.WriteLine($"\nМiсто: {_cityName}");
            Console.WriteLine($"Країна: {_countryName}");
            Console.WriteLine($"Кiлькiсть жителiв: {_population}");
            Console.WriteLine($"Поштовий iндекс: {_postalCode}");
            Console.WriteLine("Райони:");

            foreach (string district in _districts)
            {
                Console.WriteLine($"- {district}");
            }
        }
    }
    internal class Lab_3_2_Vasyliev
    {
        static void Main()
        {
            City Kremenchuk = new City("Kremenchuk", "Ukraine", 250000, 39600, ["Krukiv","Rakivka", "Molodizhniy", "Centr", "Rynok"]);
            Kremenchuk.OutputData();
        }
    }
}
