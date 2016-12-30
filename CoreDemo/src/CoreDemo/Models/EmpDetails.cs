using CoreDemo.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class EmpDetails
    {
        private readonly Test1Context _db;
        public EmpDetails(Test1Context db)
        {
            _db = db;
        }
        public Reg GetDetails()
        {
            Reg result = _db.Reg.FirstOrDefault();
            return result;
        }
    }
}
