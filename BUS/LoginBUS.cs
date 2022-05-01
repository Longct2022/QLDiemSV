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
    public class LoginBUS
    {
        DataHelper dh;
        public LoginBUS(string sqlcon)
        {
            dh = new DataHelper(sqlcon);
            
        }

        /// <summary>
        /// Khi đăng nhập, kiểm tra danh sách người dùng, nếu có người dùng và mật khẩu phù hợp
        /// Trả về một đối tượng người dùng, nếu không trả về null
        /// </summary>
        /// <param name="un">Tên đăng nhập người dùng</param>
        /// <param name="pw">mật khẩu</param>
        /// <returns></returns>
        public Users GetUsers(string un, string pw)
        {
            DataTable dt = dh.FillDataTable("SELECT * from UserList WHERE UserID = '" + un + "' and Password = '" + pw + "'");
            if (dt.Rows.Count > 0)
            {
                Users user = new Users();
                user.UserID = dt.Rows[0]["UserID"].ToString();
                user.Password = dt.Rows[0]["Password"].ToString();
                user.Role = dt.Rows[0]["Role"].ToString();
                user.FullName = dt.Rows[0]["FullName"].ToString();
                user.Sex = dt.Rows[0]["Sex"].ToString();
                user.Email = dt.Rows[0]["Email"].ToString();
                user.PhoneNumber = dt.Rows[0]["Phone"].ToString();
                return user;
            }
            else return null;
        }

        //public void UpdateUserInfo()


        //UserDAO ud = new UserDAO(sqlcon);
    }
}
