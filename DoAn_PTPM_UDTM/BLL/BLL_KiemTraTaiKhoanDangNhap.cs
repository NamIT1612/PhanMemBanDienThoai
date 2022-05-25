using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_KiemTraTaiKhoanDangNhap
    {
        DAL_KiemTraTaiKhoanDangNhap dalKiemTraTK = new DAL_KiemTraTaiKhoanDangNhap();
        public int kiemTraTaiKhoan(string user,string pass)
        {
            return dalKiemTraTK.getkiemTaiTaiKhoan(user, pass);
        }
    }
}
