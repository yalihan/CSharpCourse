using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPersonDal
    {
        void Add();
        void Update();
        void Delete();
    }
    interface ICustomerDal
    {
        void Add();
        void Update();
        void  Delete();
    }
    interface IStudentDal
    {
        void Add();
        void Update();
        void Delete();
    }
}
