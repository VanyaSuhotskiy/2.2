using System;

namespace _2_лб__1_задание
{
   
    class Address
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address adress = new Address();
            adress.index = 02090;
            adress.country = "Ukraine";
            adress.city = "Kyiv";
            adress.street = "Lobachevskogo";
            adress.house = 23;
            adress.apartment = 520;
            Console.WriteLine(adress.index + Environment.NewLine
                + adress.country + Environment.NewLine
                + adress.city + Environment.NewLine
                + adress.street + Environment.NewLine
                + adress.house + Environment.NewLine
                + adress.apartment);
            Console.ReadKey();
        }
    }

}