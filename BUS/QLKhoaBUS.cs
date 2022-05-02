using QLDiemSV.DAO;
using QLDiemSV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSV.BUS
{
    public class QLKhoaBUS
    {
        KhoaDAO khoaDAO = new KhoaDAO(Program.strcon);
        public List<Khoa> LayDSKhoa()
        {
            return khoaDAO.LayDSKhoa();
        }
    }
}
