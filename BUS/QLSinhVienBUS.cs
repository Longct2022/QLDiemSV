﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

using QLDiemSV.BUS;

namespace QLDiemSV.BUS
{
    public class QLSinhVienBUS
    {
        DataHelper dh;
        SinhVienDAO svDAO = new SinhVienDAO(Program.strcon);
        LopDAO lopDAO = new LopDAO(Program.strcon);
        public QLSinhVienBUS(string strcon)
        {
            dh = new DataHelper(strcon);
        }

        public List<SinhVien> LayDSSinhVien()
        {
            return svDAO.LayDSSinhVien();
        }
        public List<Lop> LayDSLop()
        {
            return lopDAO.LayDSLop();
        }
        public void ThemSV(SinhVien sv)
        {
            svDAO.ThemSV(sv);
        }

    }
}
