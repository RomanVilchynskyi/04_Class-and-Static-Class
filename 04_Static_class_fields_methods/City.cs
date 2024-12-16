using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Class_and_Static_Class
{
    internal class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private string[] districts;

        public City(int numberOfDistricts)
        {
            Console.Write("Enter name of city: ");
            this.cityName = Console.ReadLine();

            Console.Write("Enter the countries name: ");
            this.countryName = Console.ReadLine();

            Console.Write("Enter the population: ");
            this.population = int.Parse(Console.ReadLine()); 

            Console.Write("Enter the telephone code of the city: ");
            this.phoneCode = Console.ReadLine();

            this.districts = new string[numberOfDistricts];
            for (int i = 0; i < numberOfDistricts; i++)
            {
                Console.Write($"Enter the name of district {i + 1}: ");
                this.districts[i] = Console.ReadLine();
            }
        }

        public void SetDistrict(int index, string districtName)
        {
            if (index >= 0 && index < districts.Length)
            {
                districts[index] = districtName;
            }
        }
        public void printCity()
        {
            Console.WriteLine($"City: {cityName}");
            Console.WriteLine($"Country: {countryName}");
            Console.WriteLine($"Population: {population}");
            Console.WriteLine($"Telephone code: {phoneCode}");
            Console.WriteLine("Districts:");
            foreach (var i in districts)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public string GetCityName()
        {
            return cityName;
        }

        public void SetCityName(string name)
        {
            cityName = name;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public void SetCountryName(string name)
        {
            countryName = name;
        }

        public long GetPopulation()
        {
            return population;
        }

        public void SetPopulation(int population)
        {
            this.population = population;
        }

        public string GetPhoneCode()
        {
            return phoneCode;
        }

        public void SetPhoneCode(string code)
        {
            phoneCode = code;
        }

        public string[] GetDistricts()
        {
            return districts;
        }

        public void SetDistricts(string[] districts)
        {
            this.districts = districts;
        }
    }
}