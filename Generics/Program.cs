using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericMethods();
        }
        private static void GenericMethods()
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("İstanbul", "Giresun");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> listCustomer = utilities.BuildList<Customer>
                            (new Customer { firstName = "Alihan" }, new Customer { firstName = "Merve" });
            foreach (var customer in listCustomer)
            {
                Console.WriteLine(customer.firstName);
            }
            Console.ReadLine();
        }
    }    
    
}
