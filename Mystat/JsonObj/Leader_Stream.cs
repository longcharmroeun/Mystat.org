using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.JsonObj
{
    public class Leader_Stream
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string photo_path { get; set; }
        public int position { get; set; }

        public override string ToString()
        {
            return $"{position}. {full_name}";
        }
    }
}
