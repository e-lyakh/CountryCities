using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_Cities
{
    public partial class Form1 : Form
    {
        List<Country> countriesList = new List<Country>()
        {
            new Country("Украина"),
            new Country("Германия"),
            new Country("США")
        };        
        
        public Form1()
        {
            InitializeComponent();

            countryBox.Items.Add(countriesList[0].CountryName);
            countriesList[0].AddCity("Киев", 2907817, 650, "Столица Украины. Расположен на берегах Днепра.");
            countriesList[0].AddCity("Харьков", 1439000, 1630, "Второй по населению город Украины");
            countriesList[0].AddCity("Одесса", 1009207, 1794, "Одесса-мама");

            countryBox.Items.Add(countriesList[1].CountryName);
            countriesList[1].AddCity("Дюссельдорф", 592393, 1135, "Немецкий пром. город");
            countriesList[1].AddCity("Берлин", 3490105, 1237, "Столица Германии");
            countriesList[1].AddCity("Мюнхен", 1526149, 1158, "Главный город Баварии");

            countryBox.Items.Add(countriesList[2].CountryName);
            countriesList[2].AddCity("Вашингтон", 601723, 1790, "Столица США");
            countriesList[2].AddCity("Лос-Анджелес", 3792621, 1781, "Штат Калифорния");
            countriesList[2].AddCity("Нью-Йорк", 8405837, 1624, "Самый крупный город США. Финансовая столица мира");                                  
        }

        public void countryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i< countriesList.Count; i++)
            {
                if (countryBox.SelectedItem.ToString() == countriesList[i].CountryName)
                {
                    cityBox.Items.Clear();
                    for (int j=0; j< countriesList[i].CitiesList.Count; j++)
                    {
                        cityBox.Items.Add(countriesList[i].CitiesList[j].Name);
                    }                    
                }                
            }
            cityBox.SelectedIndex = 0;
            numericPopulation.Value = countriesList[countryBox.SelectedIndex].CitiesList[0].Population;
            textFounded.Text = $"{countriesList[countryBox.SelectedIndex].CitiesList[0].Founded}";
            textDiscription.Text = $"{countriesList[countryBox.SelectedIndex].CitiesList[0].Discription}";
        }        

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericPopulation.Value = countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Population;
            textFounded.Text = $"{countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Founded}";
            textDiscription.Text = $"{countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Discription}";
        }

        private void buttonRenew_Click(object sender, EventArgs e)
        {
            if (cityBox.Items.Count != 0)
            {
                countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Population = numericPopulation.Value;
                countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Founded = Convert.ToInt32(textFounded.Text);
                countriesList[countryBox.SelectedIndex].CitiesList[cityBox.SelectedIndex].Discription = textDiscription.Text;
            }
            else
            {
                MessageBox.Show("Отсутствует город", "Нет города", 0, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveCity_Click(object sender, EventArgs e)
        {
            countriesList[countryBox.SelectedIndex].CitiesList.RemoveAt(cityBox.SelectedIndex);
            cityBox.Items.Clear();
            for (int j = 0; j < countriesList[countryBox.SelectedIndex].CitiesList.Count; j++)
            {
                cityBox.Items.Add(countriesList[countryBox.SelectedIndex].CitiesList[j].Name);
            }
            if(cityBox.Items.Count !=0 )
                cityBox.SelectedIndex = 0;
            else
            {
                numericPopulation.Value = 0;
                textFounded.Text = "";
                textDiscription.Text = "";
            }
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            if (cityNameAdd.Text != "" && numericPopulationAdd.Value != 0 && textFoundedAdd.Text != ""
                && textDiscriptionAdd.Text != "" && countryBox.SelectedIndex >= 0 )
            {
                City new_city = new City(cityNameAdd.Text, Convert.ToInt32(numericPopulationAdd.Value),
                                Convert.ToInt32(textFoundedAdd.Text), textDiscriptionAdd.Text);
                countriesList[countryBox.SelectedIndex].CitiesList.Add(new_city);
                cityBox.Items.Clear();
                for (int j = 0; j < countriesList[countryBox.SelectedIndex].CitiesList.Count; j++)
                {
                    cityBox.Items.Add(countriesList[countryBox.SelectedIndex].CitiesList[j].Name);
                }
                cityBox.SelectedIndex = cityBox.Items.Count-1;
                cityNameAdd.Text = "";
                numericPopulationAdd.Value = 0;
                textFoundedAdd.Text = "";
                textDiscriptionAdd.Text = "";
            }
            else
                MessageBox.Show("Внесите всю информацию по новому городу либо укажите страну",
                    "Недостаточно данных", 0, MessageBoxIcon.Warning);
            
        }
    }
}