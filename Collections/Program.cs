using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //WhyNeedCollections();
            //WorkingWithArrayList();
            //WorkingWithGenericCollections();
            //WorkingWithGenericCollectionsAdvance();
            Console.ReadLine();
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string toString()
            {
                return "Id : "+Id +"\tFirst Name : "+FirstName;
            }
        }
        private static void WorkingWithGenericCollectionsAdvance()
        {
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id=0,FirstName = "Alihan" });
            //customers.Add(new Customer { Id = 1, FirstName = "Merve" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 0, FirstName = "Alihan" },
                new Customer { Id = 1, FirstName = "Merve" }
            };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }
        }
        private static void WorkingWithGenericCollections()
        {
            List<string> cities = new List<string>();
            cities.Add("İstanbul");
            // cities.Add(1); --> olmaz
            cities.Add("Antalya");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
        private static void WorkingWithArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add(1);
            cities.Add(1.34);
            cities.Add('a');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void WhyNeedCollections()
        {
            string[] cities = { "İstanbul", "Giresun" };
            cities = new string[2];
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
