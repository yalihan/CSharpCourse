﻿using MyPasswords.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPasswords.DAL.Abstract
{
    public interface IEntityDao<TEntity> where TEntity : class,IEntity,new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter=null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
