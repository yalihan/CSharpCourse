using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PersonManager
    {
        public void Add(IPerson iPerson)
        {
            Console.WriteLine(iPerson.Id);
            Console.WriteLine(iPerson.FirstName);
            Console.WriteLine(iPerson.LastName);
        }

    }
    class StudentManager
    {
        public void Add(IStudentDal iStudentDal)
        {
            iStudentDal.Add();
        }
        public void Update(IStudentDal iStudentDal)
        {
            iStudentDal.Update();
        }
        public void Delete(IStudentDal iStudentDal)
        {
            iStudentDal.Delete();
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal iCustomerDal)
        {
            iCustomerDal.Add();
        }
        public void Update(ICustomerDal iCustomerDal)
        {
            iCustomerDal.Update();
        }
        public void Delete(ICustomerDal iCustomerDal)
        {
            iCustomerDal.Delete();
        }
    }
}
