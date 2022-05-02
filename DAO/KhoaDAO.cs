using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class KhoaDAO
    {
        DataHelper dh;
        DataTable dt;
        public KhoaDAO(string sqlcon)
        {
            dh = new DataHelper(sqlcon);
        }
        public List<Khoa> LayDSKhoa()
        {
            List<Khoa> list = new List<Khoa>();
            dt = dh.FillDataTable("Select * from KHOA");
            foreach (DataRow dr in dt.Rows)
            {
                Khoa khoa = new Khoa
                {
                    MaKhoa = dr["MaKhoa"].ToString(),
                    TenKhoa = dr["TenKhoa"].ToString()
                };
                list.Add(khoa);
            }    

            return list;
        }
    }
}
