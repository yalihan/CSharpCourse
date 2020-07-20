using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager()
        {

        }
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items!" + _count);
        }
        public void Add()
        {
            Console.WriteLine("Added {0} items!" + _count);
        }
    }
    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
