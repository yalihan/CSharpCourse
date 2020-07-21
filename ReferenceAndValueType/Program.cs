using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine("number2 : " + number2);
            string[] cities1 = { "Antalya", "Afyon", "Ankara" };
            string[] cities2 = { "Bursa", "Balıkesir", "Bolu" };
            cities2 = cities1;
            //cities1 = cities2;
            cities1[0] = "İstanbul";
            Console.WriteLine("Cities1[0] : " + cities1[0] + "\nCities2[0] : " + cities2[0]);
            Console.WriteLine("Cities1[1] : " + cities1[1] + "\nCities2[1] : " + cities2[1]);
            Console.ReadLine();
        }
    }
}
