using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.DAO;
using QLDiemSV.Entities;

namespace QLDiemSV.BUS
{
    public class CapNhatTKBUS
    {

        DataHelper dh;
        UserDAO uDAO = new UserDAO(Program.strcon);
        public CapNhatTKBUS(string strcon)
        {
            dh = new DataHelper(strcon);
        }
        
        public void SuaUser(Users user)
        {
            uDAO.SuaUser(user);
        }
        public List<Users> LayDSUser()
        {
            return uDAO.LayUsers();
        }
    }
}
