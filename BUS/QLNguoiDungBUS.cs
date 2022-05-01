using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSV.BUS
{
    public class QLNguoiDungBUS
    {
        DataHelper dh;
        UserDAO ud = new UserDAO(Program.strcon);
        public QLNguoiDungBUS(string sqlcon)
        {
            dh = new DataHelper(sqlcon);
        }
        public void SuaUser(Users u)
        {
            ud.SuaUser(u);
        }
        public List<Users> LayUser()
        {
            return ud.LayUsers();
        }
        public void ThemUser(Users nuser)
        {
            ud.ThemUser(nuser);
        }
        public void XoaUser(string userID)
        {
            ud.XoaUser(userID);
        }
    }
}
