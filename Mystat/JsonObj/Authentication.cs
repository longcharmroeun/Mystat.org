using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.JsonObj
{
    class Authentication:IDisposable
    {
        public string application_key { get; set; }
        public int id_city { get; set; }
        public string password { get; set; }
        public string username { get; set; }

        public void Dispose()
        {
            application_key = null;
            username = null;
            password = null;
        }
    }
}
