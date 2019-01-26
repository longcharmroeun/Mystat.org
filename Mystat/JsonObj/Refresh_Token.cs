using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.JsonObj
{
    public class Refresh_Token:IDisposable
    {
        public string refresh_token { get; set; }

        public void Dispose()
        {
            refresh_token = string.Empty;
        }
    }
}
