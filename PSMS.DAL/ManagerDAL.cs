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
    }
    class ManagerDAL:DalInterface
    {

        public Manager UserLogin(string User_Name)
        {
            throw new NotImplementedException();
        }
    }
}
