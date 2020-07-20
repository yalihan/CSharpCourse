using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Constructor
    {
        static void Main(string[] args)
        {
            //ConstructorIntroMethods();
            //ConstructorInjectionMethods();
            //BaseClassConstructorMethods();
            StaticClassesAndMethodsS();
            Console.ReadLine();
        }
        private static void StaticClassesAndMethodsS()
        {
            Teacher.Number = 10;
            Utilies.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
        }
        private static void BaseClassConstructorMethods()
        {
            PersonManager personManager = new PersonManager("Product");
            personManager.Message();
            personManager.Add();
        }
        private static void ConstructorInjectionMethods()
        {
            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();
        }

        private static void ConstructorIntroMethods()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product1 = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Desktop");
        }
    }
}
