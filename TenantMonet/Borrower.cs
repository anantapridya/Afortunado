using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenantMonet
{
    class Borrower
    {
        private string _ID;
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _Job;
        public string Job
        {
            get { return _Job; }
            set { _Job = value; }
        }
        public void Detail(string id, string Name, string Address, string Job)
        {
            _ID = id;
            _Name = Name;
            _Address = Address;
            _Job = Job;
        }

/*
        public DateTime GetDueDate()
        {
            DateTime ret = DateTime.Now;
            ret += new TimeSpan(DUE_DAYS, 23 - ret.Hour, 59 - ret.Minute, 59 - ret.Second, 999 - ret.Millisecond);
            return ret;
        }*/
    }
}
