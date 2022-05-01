using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.DAO
{
    public class LopDAO
    {
        DataHelper dh;
        DataTable dt;
        public LopDAO(string sqlcon)
        {
            dh = new DataHelper(Program.strcon);
        }

        public List<Lop> LayDSLop()
        {
            List<Lop> llop = new List<Lop>();
            dt = dh.FillDataTable("select * from LOP");
            foreach (DataRow dr in dt.Rows)
            {
                llop.Add(new Lop
                {
                    MaLop = dr["MaLop"].ToString(),
                    MaKhoa = dr["MaKhoa"].ToString(),
                    TenLop = dr["TenLop"].ToString()
                });
            }
            return llop;
        }
    }
}
