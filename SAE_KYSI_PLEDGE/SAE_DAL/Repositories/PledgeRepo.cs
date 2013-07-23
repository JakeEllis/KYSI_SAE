using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_DAL.Repositories
{
    public class PledgeRepo : IRepository<PLEDGE>
    {
        private SAE_DB _content = null;

        public PledgeRepo()
        {
            _content = new SAE_DB();
        }

        public PLEDGE getById(PLEDGE PledgeObject)
        {
            throw new NotImplementedException();
        }

        public PLEDGE[] getAll()
        {
            throw new NotImplementedException();
        }

        public void add(PLEDGE pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void update(PLEDGE pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void remove(PLEDGE pledgeObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PLEDGE> query(System.Linq.Expressions.Expression<Func<PLEDGE, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
