using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.ProgressJsonObj
{
    public class Subject_History
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
