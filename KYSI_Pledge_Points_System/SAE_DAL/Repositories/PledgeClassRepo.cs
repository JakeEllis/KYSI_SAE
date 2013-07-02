using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SAE_DAL.Repositories
{
    public class PledgeClassRepo
    {
        SAEDB _Context;

        public void Get_Class_Name()
        {
            _Context = new SAEDB();
            PLEDGE_CLASS PC = new PLEDGE_CLASS();
            string ClassName = PC.PLEDGE_CLASS_NAME;
        }


        public void Get_Class_Semester()
        {
            _Context = new SAEDB();
        }

        public void Get_Class_Year()
        {
            _Context = new SAEDB();
        }

        public void Get_Pledge_ED()
        {
            _Context = new SAEDB();
        }
        public void Get_Co_Pledge()
        {
            _Context = new SAEDB();
        }

        public void Get_Pledge_Count()
        {
            _Context = new SAEDB();
        }

        public void Get_Initiated_Count()
        {
            _Context = new SAEDB();
        }

        public void Get_Pledge_Drop_Count()
        {
            _Context = new SAEDB();
        }

    }
}
