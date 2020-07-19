using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("SqlServer Customer Added");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("SqlServer Customer Updated");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("SqlServer Customer Deleted");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("Oracle Customer Added");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("Oracle Customer Updated");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("Oracle Customer Deleted");
        }
    }
    class MsSqlCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("MsSql Customer Added");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("MsSql Customer Updated");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("MsSql Customer Deleted");
        }
    }
}
