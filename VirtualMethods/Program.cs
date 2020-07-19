using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Delete();
            Console.ReadLine();
        }
    }
    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : DataBase
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer Code");
            base.Add();
        }
        
    }
    class MySql : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql Code");
        }
    }
}
