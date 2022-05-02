using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.BUS
{
    public class QLLopBUS
    {
        LopDAO lDAO = new LopDAO(Program.strcon);
        //QLLopBUS bus = 
        public List<Lop> LayDSLop()
        {
            return lDAO.LayDSLop();
        }
        public List<Lop> LayDSLop(string khoa)
        {
            return lDAO.LayDSLop(khoa);
        }
        public void XoaLop(string malop)
        {
            lDAO.XoaLop(malop); 
        }
        public void ThemLop(Lop lop)
        {
            lDAO.ThemLop(lop);
        }
        public void SuaLop(Lop lop)
        {
            lDAO.SuaLop(lop);
        }
    }
}
