using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class SqlServerStudentDal : IStudentDal
    {
        void IStudentDal.Add()
        {
            Console.WriteLine("SqlServer Student Added");
        }

        void IStudentDal.Update()
        {
            Console.WriteLine("SqlServer Student Updated");
        }

        void IStudentDal.Delete()
        {
            Console.WriteLine("SqlServer Student Deleted");
        }
    }
    class OracleStudentDal : IStudentDal
    {
        void IStudentDal.Add()
        {
            Console.WriteLine("Oracle Student Added");
        }

        void IStudentDal.Update()
        {
            Console.WriteLine("Oracle Student Updated");
        }

        void IStudentDal.Delete()
        {
            Console.WriteLine("Oracle Student Deleted");
        }
    }
    class MsSqlStudentDal : IStudentDal
    {
        void IStudentDal.Add()
        {
            Console.WriteLine("MsSql Student Added");
        }

        void IStudentDal.Update()
        {
            Console.WriteLine("MsSql Student Updated");
        }

        void IStudentDal.Delete()
        {
            Console.WriteLine("MsSql Student Deleted");
        }
    }
}
