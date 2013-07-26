using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;


namespace SAE_DAL.Repositories
{
    interface IRepository<T>
    {
        T getById(T PledgeObject);
        T[] getAll();
        void add(T pledgeObject);
        void update(T pledgeObject);
        void remove(T pledgeObject);
        IQueryable<T> query(Expression<Func<T, bool>> filter);

    }
}
