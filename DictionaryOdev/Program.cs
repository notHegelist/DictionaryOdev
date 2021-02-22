using System;

namespace DictionaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();

            cities.Add(10, "Balıkesir");
            cities.Add(11, "Bilecik");
            cities.Add(16, "Bursa");
            cities.Add(17, "Çanakkale");
            cities.Add(22, "Edirne");
            cities.Add(34, "İstanbul");
            cities.Add(39, "Kırklareli");
            cities.Add(41, "Kocaeli");
            cities.Add(54, "Sakarya");
            cities.Add(59, "Tekirdağ");
            cities.Add(77, "Yalova");

            Console.WriteLine("Marmara Bölgesi İllerinden Birinin Plaka Numarasını Giriniz.");
            int plaque = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(cities[plaque]);
            }
            catch 
            {

                Console.WriteLine("Hatalı Numara Girdiniz.");
                Console.WriteLine("");
                Console.WriteLine("Girdiğiniz Değer Marmara Bölgesine Ait Bir Plaka Numarası Değildir.");

            }
        }
    }
}
