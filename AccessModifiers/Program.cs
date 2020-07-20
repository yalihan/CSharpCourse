using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Customer();
            person.LastName = "Erisime acik";
        }
    }
    public class Person
    {
        int Id;
        protected string FirstName;
        public string LastName;
    }
    class Customer : Person
    {
        public void Save()
        {
            FirstName = "Alihan";
            LastName = "Yılmaz";
        }
    }
    internal class Student : Person
    {
        public void Save()
        {
            LastName = "Yılmaz";
        }
    }
}
