using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HoaDon
    {
        QLDTDataContext qldt = new QLDTDataContext();

        //Load Hóa đơn theo mã khách hàng và trạng thái

        public List<HOADON> loadHD()
        {
            return qldt.HOADONs.ToList();
        }
        public List<HOADON> loadTheoMaKHVaTT(string MaKH, int tt)
        {
            List<HOADON> lstHD = qldt.HOADONs.Where(s => s.MaKhachHang == MaKH && s.TrangThai == tt).ToList();
            return lstHD;
        }
        public List<HOADON> loadTheoTKVaTT(string tk, int tt)
        {
            List<HOADON> lstHD = qldt.HOADONs.Where(s => s.tk == tk && s.TrangThai == tt).ToList();
            return lstHD;
        }
        public bool themHD(string maKH, string maSP, string tk, int slBan, int gb, DateTime nb, int tt)
        {
            HOADON hd = new HOADON();
            hd.MaKhachHang = maKH;
            hd.MaSP = maSP;
            hd.tk = tk;
            hd.SoLuongBan = slBan;
            hd.GiaBan = gb;
            hd.NgayBan = nb;
            hd.TrangThai = tt;
            qldt.HOADONs.InsertOnSubmit(hd);
            qldt.SubmitChanges();
            return true;
        }
        public bool suaHD(string maKH, string maSP, string tk, int slBan, int gb, DateTime nb)
        {
            HOADON hd = qldt.HOADONs.Where(s => s.MaKhachHang == maKH && s.NgayBan == nb).FirstOrDefault();
            hd.MaSP = maSP;
            hd.tk = tk;
            hd.SoLuongBan = slBan;
            hd.GiaBan = gb;
            qldt.SubmitChanges();
            return true;
        }
        public bool suaSoLuongMua(string maKH, DateTime nb, int soluong)
        {
            HOADON hd = qldt.HOADONs.Where(s => s.MaKhachHang == maKH && s.NgayBan == nb).FirstOrDefault();
            hd.SoLuongBan = soluong;
            qldt.SubmitChanges();
            return true;
        }
        public bool xoaHoaDon(string maKH, DateTime nb)
        {
            HOADON hd = qldt.HOADONs.Where(s => s.MaKhachHang == maKH && s.NgayBan == nb).FirstOrDefault();

            qldt.HOADONs.DeleteOnSubmit(hd);
            qldt.SubmitChanges();

            return true;
        }
        public string tinhTongALL()
        {
            int tong = 0;
            var lstHD = qldt.HOADONs.ToList();
            foreach (var a in lstHD)
            {
                tong = tong + ((int)a.SoLuongBan * (int)a.GiaBan);
            }
            return tong.ToString();
        }
        public string tinhTongCacSPDaBan(string tenDN)
        {
            int tong = 0;
            var lstHD = qldt.HOADONs.Where(s => s.tk.Equals(tenDN) && s.TrangThai == 1).ToList();
            foreach (var a in lstHD)
            {
                tong = tong + ((int)a.SoLuongBan * (int)a.GiaBan);
            }
            return tong.ToString();
        }
        public bool capNhatTrangThaiBan(string maKH)
        {
            var lst = qldt.HOADONs.Where(s => s.MaKhachHang == maKH).ToList();
            foreach(var a in lst)
            {
                a.TrangThai = 1;
            }
            qldt.SubmitChanges();
            return true;
        }
        public bool KTKNKhachHang(string maKH)
        {
            var lst = qldt.HOADONs.ToList();
            foreach (var a in lst)
            {
                if(a.MaKhachHang.Equals(maKH))
                {
                    return false;
                }    
            }
            return true;
        }
        public bool KTKNSanPham(string maSP)
        {
            var lst = qldt.HOADONs.ToList();
            foreach (var a in lst)
            {
                if (a.MaSP.Equals(maSP))
                {
                    return false;
                }
            }
            return true;
        }
        public bool KTKNTaiKhoan(string tk)
        {
            var lst = qldt.HOADONs.ToList();
            foreach (var a in lst)
            {
                if (a.tk.Equals(tk))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
