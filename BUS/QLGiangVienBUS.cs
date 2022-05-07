using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.DAO;
using QLDiemSV.Entities;

namespace QLDiemSV.BUS
{
    public class QLGiangVienBUS
    {
        DataHelper dh;
        GiangVienDAO gvDAO = new GiangVienDAO(Program.strcon);
        KhoaDAO khoaDAO = new KhoaDAO(Program.strcon);
        public QLGiangVienBUS(string strcon)
        {
            dh = new DataHelper(strcon);
          
        }

        public List<GiangVien> LayDSGiangVien()
        {
            return gvDAO.LayDSGiangVien();
        }
        public List<GiangVien> LayDSGiangVienAll(string makhoa)
        {
            return gvDAO.LayDSGiangVienAll(makhoa);
        }
        public List<Khoa> LayDSKhoa()
        {
            return khoaDAO.LayDSKhoa();
        }
        public void ThemGV(GiangVien gv)
        {
            gvDAO.ThemGV(gv);
            //khoaDAO.SuaDS(1, gv.MaKhoa);
        }
        public void XoaGV(string maGV)
        {
            gvDAO.XoaGV(maGV);
        }
        public void SuaGV(GiangVien gv)
        {
            gvDAO.SuaGV(gv);
        }

    }
}

