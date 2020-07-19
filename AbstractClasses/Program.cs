using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }
    class Oracle : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle");
        }
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
