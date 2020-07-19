using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new CustomerManager();
            manager.Add();
            manager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Alihan";
            customer1.LastName = "Yılmaz";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Merve",
                LastName = "Yılmaz",
                City = "İstanbul"
            };
            Console.WriteLine(customer2);

            Console.ReadLine();
        }
    }
}
