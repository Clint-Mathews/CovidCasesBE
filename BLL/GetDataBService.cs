using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GetDataBService
    {
        private readonly DBGetData _data;

        public GetDataBService(DBGetData data)
        {
            _data = data;
        }
    }
}
