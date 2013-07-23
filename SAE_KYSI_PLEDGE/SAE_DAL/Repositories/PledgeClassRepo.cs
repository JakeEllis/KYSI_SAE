using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAE_DAL.Repositories
{
    public class PledgeClassRepo : IRepository<PLEDGE_CLASS>   
    {

        private SAE_DB _context = null;

        public PledgeClassRepo()
        {
            _context = new SAE_DB();
        }

        public PLEDGE_CLASS getById(PLEDGE_CLASS PledgeObject)
        {
            throw new NotImplementedException();
        }

        public PLEDGE_CLASS[] getAll()
        {
            throw new NotImplementedException();
        }

        public void add(PLEDGE_CLASS pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void update(PLEDGE_CLASS pledgeObject)
        {
            throw new NotImplementedException();
        }

        public void remove(PLEDGE_CLASS pledgeObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PLEDGE_CLASS> query(System.Linq.Expressions.Expression<Func<PLEDGE_CLASS, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
