using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Cities
{
    class Country
    {
        public string CountryName { get; set; }       
        public List<City> CitiesList = new List<City>();
        
        public Country (string CountryName)
        {
            this.CountryName = CountryName;
        }

        public void AddCity(string name, int population, int founded, string discription)
        {
            City c = new City(name, population, founded, discription);
            CitiesList.Add(c);
        }

        //public void RemoveCity(int cityNum)
        //{
        //    CitiesList.RemoveAt(cityNum);
        //}

        //public City GetCity(int cityNum)
        //{
        //    return CitiesList[cityNum];
        //}
    }
}