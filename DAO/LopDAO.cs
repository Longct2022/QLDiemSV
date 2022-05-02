using QLDiemSV.Entities;
using System.Collections.Generic;
using System.Data;

namespace QLDiemSV.DAO
{
    public class LopDAO
    {
        readonly DataHelper dh;
        //DataTable dt;
        public LopDAO(string sqlcon)
        {
            dh = new DataHelper(Program.strcon);
        }

        public List<Lop> LayDSLop()
        {
            List<Lop> llop = new List<Lop>();
            var rows = dh.FillDataTable("select * from LOP").Rows;
            foreach (DataRow dr in rows)
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
