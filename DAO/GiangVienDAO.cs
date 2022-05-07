using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.Entities;
using QLDiemSV.BUS;
using System.Data;

namespace QLDiemSV.DAO
{
    public class GiangVienDAO
    {
        DataHelper dh;
        DataTable dt = new DataTable();
        public GiangVienDAO(string sqlcon)
        {
            dh = new DataHelper(sqlcon);
        }
        public List<GiangVien> LayDSGiangVien()
        {
            List<GiangVien> lgv = new List<GiangVien>();
            dt = dh.FillDataTable("select * from GIANG_VIEN");
            foreach (DataRow dr in dt.Rows)
            {
                lgv.Add(new GiangVien
                {
                    MaGV = dr["MaGV"].ToString(),
                    TenGV = dr["TenGV"].ToString(),
                    GioiTinh = dr["GioiTinh"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Email = dr["Email"].ToString(),
                    PhanloaiGV = dr["PhanloaiGV"].ToString(),
                    MaKhoa = dr["MaKhoa"].ToString()
                });
            }
            return lgv;
        }

        public List<GiangVien> LayDSGiangVienAll(string maKhoa)
        {
            List<GiangVien> lgv = new List<GiangVien>();
            dt = dh.FillDataTable("select * from GIANG_VIEN Where MaKhoa = '" + maKhoa + "'");
            foreach (DataRow dr in dt.Rows)
            {
                lgv.Add(new GiangVien
                {
                    MaGV = dr["MaGV"].ToString(),
                    TenGV = dr["TenGV"].ToString(),
                    GioiTinh = dr["GioiTinh"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Email = dr["Email"].ToString(),
                    PhanloaiGV = dr["PhanloaiGV"].ToString(),
                    MaKhoa = dr["MaKhoa"].ToString()
                });
            }
            return lgv;
        }
        public void ThemGV(GiangVien gv)
        {
            dh.AddRow(dt, gv.MaGV, gv.TenGV, gv.GioiTinh, gv.Phone, gv.Email, gv.PhanloaiGV, gv.MaKhoa);
            dh.UpdateDataTableToDatabase(dt, "GIANG_VIEN");
        }
        public void XoaGV(string maGV)
        {
            //dh.DeleteRows(dt, "MaSV = '" + maSV + "'");
            dh.DeleteRows(dt, $"MaGV = '{maGV}'");
            dh.UpdateDataTableToDatabase(dt, "GIANG_VIEN");
        }
        public void SuaGV(GiangVien gv)
        {
            //dh.EditRow(dt, "MaSV = '" + sv.MaSV + "'", sv.MaSV, sv.HoTen, sv.NgaySinh, sv.GioiTinh, sv.DiaChi, sv.MaLop);
            dh.EditRow(dt, "MaGV = '{MaGV}'", gv.MaGV, gv.TenGV, gv.GioiTinh, gv.Phone, gv.Email, gv.PhanloaiGV, gv.MaKhoa);
            dh.UpdateDataTableToDatabase(dt, "GIANG_VIEN");
        }
    }
}
