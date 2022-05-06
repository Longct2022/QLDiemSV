using QLDiemSV.Entities;
using System.Collections.Generic;
using System.Data;

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
                Lop lop = new Lop();
                lop.MaLop = dr["MaLop"].ToString();
                lop.MaKhoa = dr["MaKhoa"].ToString();
                lop.TenLop = dr["TenLop"].ToString();
                lop.SiSo = int.Parse(dr["SiSo"].ToString());
                llop.Add(lop);
            };
            return llop;
        }
        public List<Lop> LayDSLop(string khoa)
        {
            List<Lop> llop = new List<Lop>();
            dt = dh.FillDataTable("select * from LOP where MaKhoa = '" + khoa + "'");
            foreach (DataRow dr in dt.Rows)
            {
                llop.Add(new Lop
                {
                    MaLop = dr["MaLop"].ToString(),
                    MaKhoa = dr["MaKhoa"].ToString(),
                    TenLop = dr["TenLop"].ToString(),
                    SiSo = int.Parse(dr["SiSo"].ToString())
                });
            }
            return llop;
        }
        public void ThemLop(Lop lop)
        {
            dh.AddRow(dt, lop.MaLop, lop.MaLop, lop.TenLop, lop.SiSo);
            dh.UpdateDataTableToDatabase(dt, "LOP");
        }
        public void SuaLop(Lop lop)
        {
            dh.EditRow(dt, "MaLop = " + lop.MaLop + "'", lop.MaKhoa, lop.MaLop, lop.TenLop, lop.SiSo);
            dh.UpdateDataTableToDatabase(dt, "LOP");
        }
        public void SuaSiSo(int sua, string maLop)
        {
            DataView dv = dh.Filter(dt, "MaLop = '" + maLop + "'");
            dv.AllowEdit = true;

            int siSo = int.Parse(dv[0]["SiSo"].ToString());
            dv[0]["SiSo"] = siSo + sua;

            dh.UpdateDataTableToDatabase(dt, "LOP");
        }
        public void SuaSiSo(int sua, string maLopMoi, string maLopHT)
        {
            DataView dv = dh.Filter(dt, "MaLop = '" + maLopHT + "'");
            dv.AllowEdit = true;

            int siSo = int.Parse(dv[0]["SiSo"].ToString());
            dv[0]["SiSo"] = siSo - sua;

            dv = dh.Filter(dt, "MaLop = '" + maLopMoi + "'");
            siSo = int.Parse(dv[0]["SiSo"].ToString());
            dv[0]["SiSo"] = siSo + sua;

            dh.UpdateDataTableToDatabase(dt, "LOP");
        }
        public void XoaLop(string malop)
        {
            dh.DeleteRows(dt, "MaLop = '" + malop + "'");
            dh.UpdateDataTableToDatabase(dt, "LOP");
        }
    }
}
