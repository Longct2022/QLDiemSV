using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System.Collections.Generic;

namespace QLDiemSV.BUS
{
    public class CapNhatTKBUS
    {
        private readonly DataHelper dh;
        readonly UserDAO uDAO = new UserDAO(Program.strcon);
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
