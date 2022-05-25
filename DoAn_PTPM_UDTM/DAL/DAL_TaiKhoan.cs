using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        QLDTDataContext qldt = new QLDTDataContext();
        public TAIKHOAN thongTinCuaMotTaiKhoan(string tk)
        {
            TAIKHOAN KH = qldt.TAIKHOANs.Where(s => s.tk == tk).FirstOrDefault();
            return KH;
        }
        public List<TAIKHOAN> loadTaiKhoan()
        {
            return qldt.TAIKHOANs.Where(s => s.quyen == 0).ToList();
        }
        public bool themTK(string tk, string mk,string sdt, string dc, string gt)
        {
            TAIKHOAN taiKhoan= new TAIKHOAN();
            taiKhoan.tk = tk;
            taiKhoan.mk = mk;
            taiKhoan.DiaChi = dc;
            taiKhoan.SDT = sdt;
            taiKhoan.GioiTinh = gt;
            taiKhoan.quyen = 0;

            qldt.TAIKHOANs.InsertOnSubmit(taiKhoan);
            qldt.SubmitChanges();

            return true;
        }
        public bool upDateTaiKhoan(string tk,string sdt, string dc,string gt)
        {
            TAIKHOAN taiKhoan = qldt.TAIKHOANs.Where(s => s.tk == tk).FirstOrDefault();
            taiKhoan.SDT = sdt;
            taiKhoan.DiaChi = dc;
            taiKhoan.GioiTinh = gt;

            qldt.SubmitChanges();
            return true;
        }

        public bool xoaTK(string tk)
        {
            TAIKHOAN taiKhoan = qldt.TAIKHOANs.Where(s => s.tk == tk).FirstOrDefault();

            qldt.TAIKHOANs.DeleteOnSubmit(taiKhoan);
            qldt.SubmitChanges();

            return true;
        }
        public bool upDateMatKhau(string tk, string mk)
        {
            TAIKHOAN taiKhoan = qldt.TAIKHOANs.Where(s => s.tk == tk).FirstOrDefault();
            taiKhoan.mk = mk;


            qldt.SubmitChanges();
            return true;
        }
        public bool KTKC(string tk)
        {
            var lst = qldt.TAIKHOANs.ToList();
            foreach(var a in lst)
            {
                if(a.tk.Equals(tk))
                {
                    return false;
                }    
            }
            return true;
        }
    }
}
