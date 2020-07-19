using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //InterfacesDAOs();
            //AddingAllDALs();
            Console.ReadLine();
        }

        private static void AddingAllDALs()
        {
            IStudentDal[] studentDals = new IStudentDal[3]
                        {
                new SqlServerStudentDal(),
                new OracleStudentDal(),
                new MsSqlStudentDal()
                        };
            foreach (var studentDal in studentDals)
            {
                studentDal.Add();
            }
        }

        private static void InterfacesDAOs()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new MsSqlCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            IPerson customer = new Customer
            {
                Id = 1,
                FirstName = "Alihan",
                LastName = "Yılmaz",
                Address = "Eyüp"
            };
            IPerson student1 = new Student
            {
                Id = 1,
                FirstName = "Ayşe Ferhan",
                LastName = "Yılmaz",
                Departmant = "SAY"
            };
            IPerson student2 = new Student
            {
                Id = 2,
                FirstName = "Elif Betül",
                LastName = "Tırınk",
                Departmant = "SAY"
            };
            personManager.Add(customer);
            personManager.Add(student1);
            personManager.Add(student2);
            Console.ReadLine();
        }
    }
}
