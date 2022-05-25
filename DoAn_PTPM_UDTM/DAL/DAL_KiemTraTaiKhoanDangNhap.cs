using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   
    public class DAL_KiemTraTaiKhoanDangNhap
    {
        QLDTDataContext data = new QLDTDataContext();
        public int getkiemTaiTaiKhoan(string user,string pass)
        {
            var lstTK = data.TAIKHOANs.ToList();
            foreach (var t in lstTK)
            {
                if (t.tk.Equals(user) && t.mk.Equals(pass) && t.quyen == 1)
                {
                    return 1;
                }
                else if (t.tk.Equals(user) && t.mk.Equals(pass) && t.quyen == 0)
                {
                  
                    return 2;
                }

            }


            return 0;
        }
    }
}
