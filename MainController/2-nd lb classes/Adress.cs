using System;

namespace MainController
{
    class Adress
    {
        public Adress(int index, string country, string city, string street, int house, int apartament)
            {
                this.index = index;
                this.country = country;
                this.city = city;
                this.street = street;
                this.house = house;
                this.apartament = apartament;
            }
            
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartament { get; set; }

        public void ShowInfo()
            {
                Console.WriteLine($"Index: {index}");

                Console.WriteLine($"Country: {country}");

                Console.WriteLine($"City: {city}");

                Console.WriteLine($"Street: {street}");

                Console.WriteLine($"House: {house}");

                Console.WriteLine($"Apartament: {apartament}");
            }
    }
}

