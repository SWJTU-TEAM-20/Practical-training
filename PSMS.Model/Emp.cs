using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
    public class Emp
    {
        //员工编号
        public int Empno { get; set; }
        //员工姓名
        public string Name { get; set; }
        //部门编号
        public int Detno { get; set; }
        //性别 
        public string Gender { get; set; }
        //住址
        public string Location { get; set; }
        //出生日期
        public DateTime Birthday{ get; set; }
        //入职时间
        public DateTime Hire_Date { get; set; }
        //离职时间
        public DateTime Resign_Date { get; set; }
        //入部时间
        public DateTime Depart_Date { get; set; }
        //就职状态
        public string Work_State { get; set; }
        //职务
        public string Job { get; set; }
        //电话
        public string Tel_Num { get; set; }
        //邮箱
        public string E_Mail { get; set; }
    }
}
