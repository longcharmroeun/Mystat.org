using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.JsonObj
{
    public class Attendance
    {
        public string date { get; set; }
        public int points { get; set; }
        public int? previous_points { get; set; }
        public override string ToString()
        {
            return $"{date}  Point: {points}  Previous point: {previous_points}";
        }
    }
}
