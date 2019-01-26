using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat.ProgressJsonObj
{
    public class Student_Visit
    {
        public string date_visit { get; set; }
        public int lesson_number { get; set; }
        /// <summary>
        /// 1 = normal
        /// 2 = late
        /// 3 = Absence
        /// </summary>
        public int status_was { get; set; }
        public int spec_id { get; set; }
        public string teacher_name { get; set; }
        public string spec_name { get; set; }
        public string lesson_theme { get; set; }
        public object control_work_mark { get; set; }
        public int? home_work_mark { get; set; }
        public int? lab_work_mark { get; set; }
        public int? class_work_mark { get; set; }

        public override string ToString()
        {
            if(status_was == 1)
            {
                return "Go";
            }
            else if(status_was == 2)
            {
                return "Late";
            }
            else
            {
                return "Absence";
            }
        }
    }
}
