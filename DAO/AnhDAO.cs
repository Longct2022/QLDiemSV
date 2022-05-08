using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class AnhDAO
    {
        DataHelper dh;
        DataTable dt;
        public AnhDAO(string sqlcon)
        {
            dh = new DataHelper(Program.strcon);
        }
        public void ThemAnh(Anh anh)
        {
            dh.AddRow(dt, anh.UserID, anh.Picture);
            dh.UpdateDataTableToDatabase(dt, "User2");
        }
        public void SuaAnh(Anh anh)
        {
            dh.EditRow(dt, $"UserID = '{anh.UserID}'", anh.UserID, anh.Picture);
            dh.UpdateDataTableToDatabase(dt, "User2");
        }
        public void XoaAnh(string userID)
        {
            dh.DeleteRows(dt, $"UserID = '{userID}'");
            dh.UpdateDataTableToDatabase(dt, "User2");
        }
        public List<Anh> LayDSAnh()
        {
            List<Anh> la = new List<Anh>();
            dt = dh.FillDataTable("Select * from User2");
            foreach (DataRow dr in dt.Rows)
            {
                Anh anh = new Anh();
                anh.UserID = dr["UserID"].ToString();
                if (dr["Picture"] != null)
                    anh.Picture = (byte)dr["Picture"];
                else
                    anh.Picture = null];
                la.Add(anh);
            }
            return la;
        }
    }
}
