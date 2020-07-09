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
        public int User_Id { get; set; }
        //正常出勤天数
        public int Day_Normal { get; set; }
        //迟到早退次数
        public int Day_Late { get; set; }
        //事假天数
        public int Day_Absence { set; get; }
        //病假天数
        public int Day_Ill { get; set; }
        //加班次数
        public int Work_OverT { get; set; }
        //加班费率
        public double Rate { get; set; }
    }
}
