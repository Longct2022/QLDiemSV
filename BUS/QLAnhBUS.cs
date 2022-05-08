using QLDiemSV.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemSV.Entities;

namespace QLDiemSV.BUS
{
    public class QLAnhBUS
    {
        DataHelper dh;
        AnhDAO ad = new AnhDAO(Program.strcon);

        public void SuaAnh(Anh picture)
        {
            ad.SuaAnh(picture);
        }
        public List<Anh> LayDSAnh()
        {
            return ad.LayDSAnh();
        }
        public void ThemAnh(Anh nanh)
        {
            ad.ThemAnh(nanh);
        }
        public void XoaAnh(string userID)
        {
            ad.XoaAnh(userID);
        }
    }
    
}
