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
            //AddingElementToList();
            SomeMethodsOfList();
            Console.ReadLine();
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string toString()
            {
                return "Id : " + Id + "\tFirst Name : " + FirstName;
            }
        }
        private static void SomeMethodsOfList()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Alihan" },
                new Customer { Id = 2, FirstName = "Merve" }
            };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }

            var customer3 = new Customer
            {
                Id = 3,
                FirstName = "Omer"
            };
            Console.WriteLine("\n*****Customer3 ekledik******\n");
            customers.Add(customer3);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }

            Console.WriteLine("customer3 var mi ? :"+customers.Contains(customer3));
            Console.WriteLine("new customer yapip ayni degerleri girersek var mi ? "+customers.Contains(new Customer { Id = 1, FirstName = "Alihan" }));

            var index = customers.IndexOf(customer3);
            Console.WriteLine("\nIndex of customer3 : "+index+"\n");

            Console.WriteLine("\n***** customer3 elemanini bir daha ekledik *****\n");

            customers.Add(customer3);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }

            var lastIndex = customers.LastIndexOf(customer3);
            Console.WriteLine("Last Index of customer3 : " + lastIndex);

            Console.WriteLine("\n***** customer3 ogesini 1. indexe ekledik *****\n");
            customers.Insert(1, customer3);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }

            Console.WriteLine("\n***** customer3 lerden birini sildik *****\n");
            customers.Remove(customer3);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }
            Console.WriteLine("\n***** customer listesinde, ismi Omer olanlarin hepsini sildik *****\n");
            customers.RemoveAll(c=>c.FirstName=="Omer");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }
        }
        private static void AddingElementToList()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Alihan" },
                new Customer { Id = 2, FirstName = "Merve" }
            };

            var customer3 = new Customer
            {
                Id=3,FirstName="Ömer"
            };

            customers.Add(customer3);
            
            customers.AddRange(new Customer[2]
            { 
                new Customer{Id=4,FirstName="Hamza" },
                new Customer{Id=5,FirstName="Afra"}
            });
            
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.toString());
            }
            Console.WriteLine("Element Number of Customers List : {0}", customers.Count);
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
                Console.WriteLine(city + " --> " + city.GetType());
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
