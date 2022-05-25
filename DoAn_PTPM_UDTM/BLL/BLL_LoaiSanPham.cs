using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_LoaiSanPham
    {
        DAL_LoaiSanPham dalLSP = new DAL_LoaiSanPham();
        public List<LOAISANPHAM> getLoadLSP()
        {
            return dalLSP.loadLoaiSP();
        }
    }
}
