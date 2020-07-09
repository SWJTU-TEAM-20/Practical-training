using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Model
{
    public class Salary
    {  //工资类
        //员工编号
        public int User_id { get; set; }
        //基本工资
        public double Basic { get; set; }
        //动态工资
        public double Dynamic { get; set; }
    }
}
