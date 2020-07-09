using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore;
using PSMS.Model;
namespace PSMS.DAL
{
    interface DalInterface
    {
        Manager UserLogin(string User_Name);
    }
    class ManagerDAL:DalInterface
    {

        public Manager UserLogin(string User_Name)
        {
            SqlDbHelper sqlDbHelper= new SqlDbHelper();
            
            return null;
        }
    }
}
