using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{/// <summary>
/// 考勤类
/// </summary>
    public class Check
    {    //员工编号
        public int user_id { get; set; }
        //正常出勤天数
        public int day_normal { get; set; }
        //迟到早退次数
        public int day_late { get; set; }
        //事假天数
        public int day_absence { set; get; }
        //病假天数
        public int day_ill { get; set; }
        //加班次数
        public int work_overT { get; set; }
        //加班费率
        public double rate { get; set; }
    }
}
