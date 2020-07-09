using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSMS.DAL;
using PSMS.Model;

namespace PSMS.BLL
{
    public class ManagerBLL
    {
        private ManagerDAL managerDAL;
        public ManagerBLL()
        {
            managerDAL = new ManagerDAL();
        }
        public bool ManagerLogin(string User_Name, string Password)
        {
            Manager manager = managerDAL.UserLogin(User_Name);
            return manager.password == Password;
        }
    }
}
