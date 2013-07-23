using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_DAL.Repositories
{
    public class PointsRepo : IRepository<POINT>
    {
        private SAE_DB _content = null;

        public PointsRepo()
        {
            _content = new SAE_DB();
        }

        public POINT getById(POINT PledgeObject)
        {
            throw new NotImplementedException();
        }

        public POINT[] getAll()
        {
            throw new NotImplementedException();
        }

        public void add(POINT pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void update(POINT pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void remove(POINT pledgeObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<POINT> query(System.Linq.Expressions.Expression<Func<POINT, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
