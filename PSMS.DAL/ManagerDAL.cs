using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSMS.Model;

namespace PSMS.DAL
{
    interface DalInterface
    {
        Manager UserLogin(string User_Name);
        void func();
    }
    public class ManagerDAL:DalInterface
    {
        public void func()
        {
            throw new NotImplementedException();
        }

        public Manager UserLogin(string User_Name)
        {
            SqlDbHelper sqlDbHelper= new SqlDbHelper();
            //待实现
            return null;
        }
    }
}
