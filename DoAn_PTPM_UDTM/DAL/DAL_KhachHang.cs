using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KhachHang
    {
        QLDTDataContext qldt = new QLDTDataContext();
        public List<KHACHHANG> loadKhachHang()
        {
            return qldt.KHACHHANGs.ToList();
        }
        public bool themKH(string MaKH, string tenKH, string sdt, string dc)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = MaKH;
            kh.TenKhachHang = tenKH;
            kh.SDT = sdt;
            kh.DiaChi = dc;
            kh.TrangThai = 0;

            qldt.KHACHHANGs.InsertOnSubmit(kh);
            qldt.SubmitChanges();
            return true;
        }
        public bool suaKH(string MaKH, string tenKH, string sdt, string dc)
        {
            KHACHHANG kh = qldt.KHACHHANGs.Where(s => s.MaKhachHang == MaKH).FirstOrDefault();
            kh.TenKhachHang = tenKH;
            kh.SDT = sdt;
            kh.DiaChi = dc;

            qldt.SubmitChanges();
            return true;
        }

        public bool xoaKH(string maKH)
        {
            KHACHHANG kh = qldt.KHACHHANGs.Where(s => s.MaKhachHang == maKH).FirstOrDefault();


            qldt.KHACHHANGs.DeleteOnSubmit(kh);
            qldt.SubmitChanges();
            return true;
        }
         public bool KTKCKhachHang(string maKH)
        {
            var lst = qldt.KHACHHANGs.ToList();
            foreach(var a in lst)
            {
                if (a.MaKhachHang == maKH)
                    return false;
            }    
            return true;
        }
        public bool batTrangThaiGiaoDich(string maKH)
        {
            KHACHHANG kh = qldt.KHACHHANGs.Where(s => s.MaKhachHang == maKH).FirstOrDefault();
            kh.TrangThai = 1;

            qldt.SubmitChanges();
            return true;
        }

        public bool tatTrangThaiGiaoDich(string maKH)
        {
            KHACHHANG kh = qldt.KHACHHANGs.Where(s => s.MaKhachHang == maKH).FirstOrDefault();
            kh.TrangThai = 0;

            qldt.SubmitChanges();
            return true;
        }
        public string timID()
        {
            string id = "";
            var lstKH = qldt.KHACHHANGs.ToList();
            foreach (var i in lstKH)
            {
                if (i.TrangThai == 1)
                {
                    id = i.MaKhachHang;
                    return id;
                }
            }
            return null;
        }

        public int ktTrangThai()
        {
            return qldt.KHACHHANGs.Where(s => s.TrangThai == 1).Count();
        }
        public List<KHACHHANG> timkhachHangTheoSDT(string SDT)
        {
            return qldt.KHACHHANGs.Where(s => s.SDT.Equals(SDT)).ToList();

        }


    }
}
