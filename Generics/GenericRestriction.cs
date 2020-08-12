using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericRestriction
    {
    }
    interface IRepositoryDao<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    interface IStudentDal : IRepositoryDao<Teacher>
    {

    }
    interface IEntity
    {

    }
    class Student : IEntity
    {

    }
    class Teacher : IEntity
    {

    }
}
