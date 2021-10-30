using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBGetData
    {
        private readonly CovidDataContext _context;

        public DBGetData(CovidDataContext context)
        {
            _context = context;
        }


    }
}
