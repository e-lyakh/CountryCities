using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Country_Cities
{
    class City
    {
        public string Name { get; set; }
        public decimal Population { get; set; }
        public int Founded { get; set; }
        public string Discription { get; set; }

        public City(string name, int population, int founded, string discription)
        {
            Name = name;
            Population = population;
            Founded = founded;
            Discription = discription;
        }
    }
}