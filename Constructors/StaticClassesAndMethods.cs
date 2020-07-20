using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilies
    {
        static Utilies()
        {
            Console.WriteLine("Static constructor is started!");
        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done something!");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done something2!");
        }
    }
}
