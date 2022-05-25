using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public  class BLL_TaiKhoan
    {
        DAL_TaiKhoan dalTK = new DAL_TaiKhoan();
        public List<TAIKHOAN> getLoadTaiKhoan()
        {
            return dalTK.loadTaiKhoan();
        }
        public TAIKHOAN getThongTinCaNhanTK(string tk)
        {
            return dalTK.thongTinCuaMotTaiKhoan(tk);
        }
        public bool getThemTK(string tk, string mk, string sdt, string dc, string gt)
        {
            return dalTK.themTK(tk, mk, sdt, dc, gt);
        }
        public bool getUpDateTK(string tk, string sdt, string dc, string gt)
        {
            return dalTK.upDateTaiKhoan(tk, sdt, dc, gt);
        }    

        public bool getXoaTK(string tk)
        {
            return dalTK.xoaTK(tk);
        }
        public bool getUpdateMK(string tk,string mk)
        {
            return dalTK.upDateMatKhau(tk, mk);
        }
        public bool getKTKCTaiKhoan(string tk)
        {
            return dalTK.KTKC(tk);
        }
    }
}
