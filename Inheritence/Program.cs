using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{Id=1,FirstName="Alihan",LastName="Yılmaz",City="İstanbul"},
                new Student{Id=1,FirstName="Aişe",LastName="Yılmaz",Departmant="SAY"},
                new Student{Id=2,FirstName="Elif",LastName="Tırınk",Departmant="SAY"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }

        public string toString()
        {
            return Id+FirstName + LastName + City;
        }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
        public string toString()
        {
            return Id + FirstName + LastName + Departmant;
        }
    }
}
