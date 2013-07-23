using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_DAL.Repositories
{
    public class PointsValueRepo : IRepository<POINT_VALUES>
    {
        private SAE_DB _content = null;

        public PointsValueRepo()
        {
            _content = new SAE_DB();
        }

        public POINT_VALUES getById(POINT_VALUES PledgeObject)
        {
            throw new NotImplementedException();
        }

        public POINT_VALUES[] getAll()
        {
            throw new NotImplementedException();
        }

        public void add(POINT_VALUES pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void update(POINT_VALUES pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void remove(POINT_VALUES pledgeObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<POINT_VALUES> query(System.Linq.Expressions.Expression<Func<POINT_VALUES, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
