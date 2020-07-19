using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),new Worker(),new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEater[] eaters = new IEater[2]
            {
                new Manager(),new Worker()
            };
            foreach (var eater in eaters)
            {
                eater.Eat();
            }
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(), new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEater
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEater, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager worked");
        }
        public void Eat()
        {
            Console.WriteLine("Manager ate");
        }
        public void GetSalary()
        {
            Console.WriteLine("Manager got salary");
        }
    }
    class Worker : IWorker, IEater, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Worker worked");
        }
        public void Eat()
        {
            Console.WriteLine("Worker ate");
        }
        public void GetSalary()
        {
            Console.WriteLine("Worker got salary");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot worked");
        }
    }
}
